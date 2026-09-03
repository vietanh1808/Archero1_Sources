using GameProtocol;

public class GameOverDailyTD : GameOverDailyCtrl
{
	protected override void OnOpen()
	{
	}

	protected override void OnAfterGetExp()
	{
	}

	protected override void OnAfterGetGold()
	{
	}

	protected override int GetFinishedWaveId()
	{
		return 0;
	}

	protected override void onAfterLanguageChange()
	{
	}

	protected override void UpdateTxtLayer()
	{
	}

	protected override void UpdateTxtReachLevel()
	{
	}

	protected override void CheckWinOrFail()
	{
	}

	protected override bool CanShowButtonSwitch()
	{
		return false;
	}

	private CEquipmentItem[] GetEquipItems()
	{
		return null;
	}
}
