namespace MauiApp1.Resources.Pages.Venues;

public partial class NewPage1 : ContentPage
{
    private void Initial()
    {
        Info.Text = "���ݰ������������ݣ�λ���㽭ʡ��������ɽ�����뺼�ݰ���������Ӿ���ֳơ�������˫�ݣ�����˫�ݺ�һ�����������ص��������ͣ��γɡ��������ĺ����Ļ����⣻��2018�꿪����2021�꿢��Ͷ�ã�Ϊ���ݵ�19�����˻������������ ��";
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