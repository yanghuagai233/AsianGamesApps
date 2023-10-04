namespace AsianGameApps.Resources.Pages.More;

public partial class About_Source : ContentPage
{
	public About_Source()
	{
		InitializeComponent();
	}
    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}