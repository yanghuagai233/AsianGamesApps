namespace AsianGameApps.Resources.Pages.More;

public partial class Asian_Game_Etiquette : ContentPage
{
	public Asian_Game_Etiquette()
	{
		InitializeComponent();
        ShowWebView.Source = new HtmlWebViewSource
        {
            Html = @"<h2>
    礼仪是最容易做到的事情，也是最容易忽视的事情，礼仪是最容易做到的事，也是最珍贵的东西。
    请大家学习观赛礼仪，遵守观赛礼仪，文明观赛。
</h2>


<h3>一、入场礼仪</h3>

　　1.着装文明得体。穿着应文明、得体，以舒适、休闲、整洁、大方为宜。

<br />

　　2.提前到达场馆。为确保能够准时入场观看比赛，观众应充分考虑交通与安检排队所需时间，到达比赛场馆应尽快入场，避免场馆入口处人群拥堵。
<br />

　　3.有序入场。按指引排队入场，礼让老、弱、病、残、孕者，主动配合安检人员的检查。入场馆后应迅速入座，不在过道上停留。
<br />

<h3>
    二、观赛礼仪
</h3>

    1.尊重各国家(地区)。尊重各参赛国家、地区，在升旗、奏歌环节，请肃立并行注目礼，不要在场内随意走动。
<br />

    2.向运动员表示敬意。赛前介绍运动员时，观众应用掌声表示鼓励。比赛中观众可为双方运动员鼓励加油，无论胜负，对各国（地区）参赛运动员的精彩表现给予应有的尊重。
<br />

    3.掌握喝彩时机。比赛的发球、发令时，保持安静，以免影响运动员。对精彩比赛可报以热烈的掌声，不能喝倒彩或起哄。
<br />

    4.文明使用手机。观众入场后，应自觉把手机调整为震动或静音。在接听电话时，应尽量放低音量，以免打扰他人。
<br />

    5.配合现场管理。在比赛进行中，观众不得扰乱比赛和干扰裁判员的工作，不得在比赛场馆内起哄、追逐嬉闹，不得翻越护栏。如允许拍照，应避免使用闪光灯，以免影响运动员。
<br />

    6.保持赛场文明。观众应守法、有礼、有序，理智、热情。比赛期间不随意走动与站立，不大声喧哗，不随地吐痰，不乱扔垃圾。尊重裁决，不辱骂裁判员、教练员、运动员及对方观众。
<br />

    7.爱护公物。严禁乱贴、乱画、攀爬馆内设施，不得随意触动馆内电器和消防设施。


<h3>
    三、退场礼仪
</h3>
    1.文明有序退场。观众应按座位顺序，向最近出口缓行退场，礼让老、弱、病、残、孕者，不推不挤不抢，不在馆内逗留。已退至场外的观众应尽快散离。
<br />
    2.应避免提前退场。比赛过程中，观众尽量不要提前退场，应等比赛结束后再离开；如需提前退场，应选择在中间休息时离开，以免影响其他观众。有颁奖仪式时，请在颁奖仪式结束后有序退场。
<br />
    3.维护公共环境。离开时请将垃圾带出场外并分类投放，不要把垃圾随手丢在过道上或放在座位上，以保持环境整洁。
<br />
    4.遇到突发事件时，观众应听从工作人员的指挥，按照指定路线疏散，迅速有序离开场馆。应尽可能地帮助老、弱、病、残、孕者先离开危险区域。
<br />
    5.如有其他需要，可向现场工作人员和志愿者寻求帮助。
"
        };

    }
    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}