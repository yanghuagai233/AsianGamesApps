using System.Text;

namespace MauiApp1.Resources.Pages.Venues;

public partial class Introduct : ContentPage
{
    private string place;
    private async void Initial(string filename)
    {
        Info.FontSize=32;
        string name = @"Resources\Introduct\Venues\" + filename + ".txt";
        Info.Text = await ReadTextFile(name);
    }
    public async Task<string> ReadTextFile(string filePath)
    {
        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(filePath);
        using StreamReader reader = new StreamReader(fileStream,Encoding.Default);
        return await reader.ReadToEndAsync();
    }
    
    public Introduct(string title,string filename)
    {
        InitializeComponent();
        Title = title;
        TitleLabel.BindingContext = this.Title;
        place = title;
        Initial(filename);
    }

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    public async Task NavigateToBuilding()//����
    {
        var placemark = new Placemark
        {
            CountryName = "China",
            AdminArea = "Hang Zhou",
            Thoroughfare = place,
            Locality = "Redmond"
        };

        var options = new MapLaunchOptions { Name = place };

        try
        {
            await Map.Default.OpenAsync(placemark, options);
        }
        catch (Exception ex)
        {
            // û�п��Դ򿪵ĵ�ͼӦ�ó�����޷��ҵ��ر�
        }
    }


    private async void ToMap_Clicked(object sender, EventArgs e)
    {
        await NavigateToBuilding();
    }



    public Introduct()
    {
        InitializeComponent();
        TitleLabel.BindingContext = this.Title;
        place = "";
    }
}