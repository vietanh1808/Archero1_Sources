using UnityEngine;

public class GameOverDaily130Ctrl : GameOverDailyCtrl
{
	[SerializeField]
	private GameObject _goBossLv;

	[SerializeField]
	private DxxText _textLv;

	[SerializeField]
	private DxxText _textScore;

	private bool isRankRewardPeriod;

	private bool hideRewardPanel;

	private bool isSettlementFinished;

	protected override void OnOpen()
	{
	}

	protected override void UpdateUIGetParentStatus()
	{
	}

	protected override void UpdateUIGetParentsStatus()
	{
	}

	protected override void PlayGetInternal()
	{
	}

	protected override void OnAfterGetExp()
	{
	}

	protected override void OnAfterGetGold()
	{
	}

	protected override void CheckEquips(float fEquipRatio)
	{
	}

	protected override void SendGameOver()
	{
	}

	protected override void CompleteAllAni()
	{
	}

	protected override void UpdateUILevelCtrlStatus()
	{
	}

	protected override void OnAnimationEnd()
	{
	}

	protected override void PlayGet()
	{
	}

	public override void PlayRewards()
	{
	}

	protected override void send_event_game_end_daily()
	{
	}
}
