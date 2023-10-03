using AsianGameApps.Resources.Pages.TabbedPage;

namespace AsianGameApps
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