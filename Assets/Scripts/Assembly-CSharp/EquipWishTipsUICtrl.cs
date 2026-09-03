using PureMVC.Interfaces;

public class EquipWishTipsUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_Sure;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public DxxText Text_Close;

	private int mode;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	public void OnButtonSure()
	{
	}
}
