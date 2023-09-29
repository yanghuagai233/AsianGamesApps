using MauiApp1.Resources.Pages.TabbedPage;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedItems();
        }
    }
}