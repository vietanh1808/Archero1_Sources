using UnityEngine;

public class GamePlayActivityOne_Cooperation : GamePlayActivityOneCtrl
{
	public ButtonCtrl buttonJoinIn;

	public ButtonCtrl buttonCreateRoom;

	public DxxText textJoinIn;

	public DxxText textCreateRoom;

	public GameObject buttonMask;

	public DxxText textDebug;

	public DxxText textLastReward;

	protected override void RefreshData()
	{
	}

	private bool CheatPlayDaily()
	{
		return false;
	}

	protected virtual void OnClickCreateRoom()
	{
	}

	private void ReqDailyDataAndPlay(int dailyId)
	{
	}

	private void SendTakeOffTime(int dailyId)
	{
	}

	private void OnClickJoinIn()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshLastTimeText()
	{
	}

	private void RefreshDebugInfo()
	{
	}
}
