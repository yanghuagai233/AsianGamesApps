using MauiApp1.Resources.Pages;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
            SemanticScreenReader.Announce(CounterBtn.Text);
            await Navigation.PushAsync(new ShowPhotos());
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopToRootAsync();
        }
    }
}