using System.Text;

namespace MauiApp1.Resources.Pages.Venues;

public partial class Introduct : ContentPage
{
    private string place;
    async private void Initial(string filename)
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
    public Introduct()
	{
		InitializeComponent();
        TitleLabel.BindingContext= this.Title;
        place = "";
	}
    public Introduct(string title,string filename)
    {
        InitializeComponent();
        Title = title;
        TitleLabel.BindingContext = this.Title;
        place = title;
        Initial(filename);
    }

    async private void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    public async Task NavigateToBuilding()//µ¼º½
    {
        var placemark = new Placemark
        {
            CountryName = "China",
            AdminArea = "Hang Zhou",
            Thoroughfare = place,
            Locality = "Redmond"
        };

        var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

        try
        {
            await Map.Default.OpenAsync(placemark, options);
        }
        catch (Exception ex)
        {
            // No map application available to open or placemark can not be located
        }
    }


    async private void ToMap_Clicked(object sender, EventArgs e)
    {
        await NavigateToBuilding();
    }
}