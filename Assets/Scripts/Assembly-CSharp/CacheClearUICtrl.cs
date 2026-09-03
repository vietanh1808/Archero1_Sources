using PureMVC.Interfaces;

public class CacheClearUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public DxxText Text_Cancel;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void init()
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
}
