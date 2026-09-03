using PureMVC.Interfaces;

public class BattleLevelUICtrl_Cooperation : BattleLevelUICtrl
{
	public ButtonCtrl Button_EndWatch;

	public DxxText Text_Watching;

	public DxxText Text_EndWatching;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnApplicationQuit()
	{
	}

	protected override bool GetBtnShow()
	{
		return false;
	}
}
