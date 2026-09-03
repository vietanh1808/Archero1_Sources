using PureMVC.Interfaces;

public class DailyBuyUICtrl : MediatorCtrlBase
{
	private static int mDailyId;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_GetChanceCount;

	public DxxText Text_LeftChance;

	public GoldTextCtrl DiamondCtrl;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	private int leftChance;

	private int currentCost;

	public static void SetDailyId(int dailyId)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void RefreshBuyInfo()
	{
	}

	private void ReqDataAndSendBuyTime()
	{
	}

	private void SendBuyTime(int dailyId, int diamondCost)
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
