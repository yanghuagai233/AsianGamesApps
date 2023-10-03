using System.Text;

namespace MauiApp1.Resources.Pages.Comp;

public partial class Introduct : ContentPage
{
    private async void Initial(string filename)
    {
        Info.FontSize = 32;
        string name = @"Resources\Introduct\Comp\" + filename + ".txt";
        Info.Text = await ReadTextFile(name);
    }
    public async Task<string> ReadTextFile(string filePath)
    {
        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(filePath);
        using StreamReader reader = new StreamReader(fileStream, Encoding.Default);
        return await reader.ReadToEndAsync();
    }
    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
    public Introduct(string title, string filename)
    {
        InitializeComponent();
        Title = title;
        TitleLabel.BindingContext = this.Title;
        Initial(filename);
        TitleLabel.FontSize = 40;
    }

    public Introduct()
    {
        InitializeComponent();
        TitleLabel.BindingContext = this.Title;
    }

}