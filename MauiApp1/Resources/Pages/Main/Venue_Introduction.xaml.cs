using MauiApp1.Resources.Pages.Venues;
using Microsoft.Maui.Controls;
using System.Globalization;

namespace MauiApp1.Resources.Pages.Main;

public partial class Venue_Introduction : ContentPage
{
	public Venue_Introduction()
	{
		InitializeComponent();
        
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    async private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Frame a = sender as Frame;
        string text;
        if (a.Content is Grid grid)
        {
            foreach (var view in grid.Children)
            {
                if (view is Label label)
                {
                    // Now you can use the label
                    text = label.Text;
                    await Navigation.PushModalAsync(new NewPage1(text));
                }
            }
        }
        
    }
}