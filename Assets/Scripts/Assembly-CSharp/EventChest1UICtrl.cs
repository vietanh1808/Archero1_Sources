using PureMVC.Interfaces;

public class EventChest1UICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Start;

	public EventChest1TurnCtrl mTurnCtrl;

	private TurnTableType resultType;

	private string[] args;

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
