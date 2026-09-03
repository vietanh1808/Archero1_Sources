using PureMVC.Interfaces;

public class GDPRUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Agree;

	public DxxText Text_Service;

	public DxxText Text_Privacy;

	public ButtonCtrl Button_Service;

	public ButtonCtrl Button_Privacy;

	public ButtonCtrl Button_Agree;

	protected override void OnInit()
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
