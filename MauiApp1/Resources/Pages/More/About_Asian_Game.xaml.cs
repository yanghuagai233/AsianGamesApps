namespace AsianGameApps.Resources.Pages.More;

public partial class About_Asian_Game : ContentPage
{
	public About_Asian_Game()
	{
		InitializeComponent();
	}

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}