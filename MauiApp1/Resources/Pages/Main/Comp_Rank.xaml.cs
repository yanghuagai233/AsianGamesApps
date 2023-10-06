using AsianGameRank;
using System.Collections.ObjectModel;

namespace AsianGameApps.Resources.Pages.Main;

public partial class Comp_Rank : ContentPage
{
    private ObservableCollection<RankInfo> RankData;
    private async void setBingding()
    {
        RankData =await GetRank.GetRankInfo();
        LV.ItemsSource = RankData;


    }
    public Comp_Rank()
    {
        RankData = new ObservableCollection<RankInfo>();
        InitializeComponent();
        setBingding();
    }

    private void RefreshButton_Clicked(object sender, EventArgs e)
    {
        setBingding();

    }
}