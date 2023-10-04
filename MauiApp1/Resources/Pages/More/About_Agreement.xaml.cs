namespace AsianGameApps.Resources.Pages.More;

public partial class About_Agreement : ContentPage
{
	public About_Agreement()
	{
		InitializeComponent();
	}

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
            await Navigation.PopModalAsync();
       
    }
}