using PureMVC.Interfaces;

public class GuildGiftUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public DxxText Text_Title;

	public DxxText Text_Desc;

	public DxxText Text_NoGift;

	public GuildGiftTableView giftTableView;

	public GuildGiftInfoWindow Window_Info;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	public void setGiftNoTextShow(bool show)
	{
	}
}
