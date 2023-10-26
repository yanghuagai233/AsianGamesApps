namespace AsianGameApps.Resources.Pages.More;

public partial class Buy_Items : ContentPage
{
	public Buy_Items()
	{
		InitializeComponent();

    }
    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void JumpToBuyLink_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://hzyyh.world.tmall.com/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }

    private async void JumpToTicketLink_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://ticket.hangzhou2022.cn/#/home");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }

    private void JumpToTicketLink_Focused(object sender, FocusEventArgs e)
    {

    }
}