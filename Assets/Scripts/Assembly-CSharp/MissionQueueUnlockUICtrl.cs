using PureMVC.Interfaces;

public class MissionQueueUnlockUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Quick;

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Diamond;

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

	private void android_escape()
	{
	}

	private void onButtonQuick()
	{
	}
}
