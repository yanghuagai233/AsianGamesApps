namespace MauiApp1.Resources.Pages.Venues;

public partial class NewPage1 : ContentPage
{
    private void Initial()
    {
        Info.Text = "杭州奥体中心体育馆，位于浙江省杭州市萧山区，与杭州奥体中心游泳馆又称“化蝶”双馆，采用双馆合一的设计理念，独特的流线造型，形成“化蝶”的杭州文化主题；于2018年开工，2021年竣工投用，为杭州第19届亚运会篮球比赛场馆 。";
        Info.FontSize = 32;
    }
	public NewPage1()
	{
		InitializeComponent();
        TitleLabel.BindingContext= this.Title;
        Initial();
	}
    public NewPage1(string title)
    {
        InitializeComponent();
        Title = title;
        TitleLabel.BindingContext = this.Title;
        Initial();
    }

    async private void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}