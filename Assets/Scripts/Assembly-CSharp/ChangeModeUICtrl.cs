using PureMVC.Interfaces;

public class ChangeModeUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Normal;

	public DxxText Text_Normal;

	public ButtonCtrl Button_Hero;

	public DxxText Text_Hero;

	public ButtonCtrl Button_Challenge;

	public DxxText Text_Challenge;

	protected override void OnInit()
	{
	}

	private void change_mode(GameMode mode)
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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
