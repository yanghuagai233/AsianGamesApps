using AsianGameRank;

namespace MauiApp1.Resources.Pages.Main;

public partial class Comp_Rank : ContentPage
{
    private async void setBingding()
    {
        List<RankInfo> info =await GetRank.GetRankInfo();
        Label1.BindingContext = info[0];
        Label2.BindingContext = info[1];
        Label3.BindingContext = info[2];
        Label4.BindingContext = info[3];
        Label5.BindingContext = info[4];
        Label6.BindingContext = info[5];
        Label7.BindingContext = info[6];
        Label8.BindingContext = info[7];
        Label9.BindingContext = info[8];
        Label10.BindingContext = info[9];
        Label11.BindingContext = info[10];
        Label12.BindingContext = info[11];
        Label13.BindingContext = info[12];
        Label14.BindingContext = info[13];
        Label15.BindingContext = info[14];
        Label16.BindingContext = info[15];
        Label17.BindingContext = info[16];
        Label18.BindingContext = info[17];
        Label19.BindingContext = info[18];
        Label20.BindingContext = info[19];
        Label21.BindingContext = info[20];
        Label22.BindingContext = info[21];
        Label23.BindingContext = info[22];
        Label24.BindingContext = info[23];
        Label25.BindingContext = info[24];
        Label26.BindingContext = info[25];
        Label27.BindingContext = info[26];
        Label28.BindingContext = info[27];
        Label29.BindingContext = info[28];
        Label30.BindingContext = info[29];
        Label31.BindingContext = info[30];
        Label32.BindingContext = info[31];
        Label33.BindingContext = info[32];
        Label34.BindingContext = info[33];
        Label35.BindingContext = info[34];
        Label36.BindingContext = info[35];


    }
    public Comp_Rank()
    {
        InitializeComponent();
        setBingding();
    }
}