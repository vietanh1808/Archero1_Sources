using PureMVC.Interfaces;

public class MainUIChallengeCtrl : MediatorCtrlBase
{
	public DxxText Text_Current;

	public DxxText Text_Play;

	public GoldTextCtrl mKeyCtrl;

	public ButtonCtrl Button_Play;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public ChallengeLevelCtrl mLevelCtrl;

	public ChallengeContentCtrl mContentCtrl;

	private int mCurrentID;

	protected override void OnInit()
	{
	}

	private void Update()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void go_next()
	{
	}

	private void show_play(bool value)
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
