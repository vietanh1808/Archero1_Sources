using PureMVC.Interfaces;

public class BattleSLGUICtrl : BattleLevelUICtrl
{
	public SLGRoundCountdown inRoundCountdown;

	public SLGRoundCountdown beforeRoundCountdown;

	public BattleGoldCtrl slgTalent;

	public BattleGoldCtrl slgCampTalent;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
