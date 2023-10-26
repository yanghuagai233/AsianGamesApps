using AsianGameApps.Resources.Pages.More;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;

namespace AsianGameApps.Resources.Pages.Main;

public partial class More_Info : ContentPage
{

    public More_Info()
	{
		InitializeComponent();
        
	}



    private async void Source_Tapped(object sender, EventArgs e)
    {

        await Navigation.PushModalAsync(new About_Source());
    }

    private async void ViewCell_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new About_Asian_Game());
    }

    private async void ViewCell_Tapped_1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Buy_Items());
    }

    private async void ViewCell_Tapped_2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Match_Schedule());
    }

    private async void ViewCell_Tapped_3(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Asian_Game_Etiquette());
    }
}