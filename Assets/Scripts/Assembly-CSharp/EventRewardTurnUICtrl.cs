using PureMVC.Interfaces;

public class EventRewardTurnUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Start;

	public ButtonCtrl Button_Close;

	public GoldTextCtrl mGoldCtrl;

	public GameTurnTableCtrl mTurnCtrl;

	private TurnTableType resultType;

	private int[] qualities;

	private TurnTableType[] types;

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
