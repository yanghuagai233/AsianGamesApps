namespace MauiApp1.Resources.Pages;

public partial class ShowPhotos : ContentPage
{
	public ShowPhotos()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();

    }
}