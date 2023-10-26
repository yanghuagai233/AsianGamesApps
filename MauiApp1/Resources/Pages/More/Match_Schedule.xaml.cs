namespace AsianGameApps.Resources.Pages.More;

public partial class Match_Schedule : ContentPage
{
	public Match_Schedule()
	{
		InitializeComponent();
	}
    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}