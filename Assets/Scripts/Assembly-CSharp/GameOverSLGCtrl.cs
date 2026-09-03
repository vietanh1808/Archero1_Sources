using GameProtocol;

public class GameOverSLGCtrl : GameOverLevelCtrl
{
	private int occupyValue;

	private int occupyValueExtra;

	private int attackCampID;

	private int tileId;

	private GameModeCampBattle slgModeData => null;

	protected override bool HaveReward()
	{
		return false;
	}

	protected override void onAfterLanguageChange()
	{
	}

	protected override void InitSLGHonor(bool _ifStageComplete)
	{
	}

	protected override void OnLoading()
	{
	}

	protected override void update_stage()
	{
	}

	protected override void CheckWinOrFail()
	{
	}

	private int GetFinishedWaveId()
	{
		return 0;
	}

	protected override void UpdateTxtLayer()
	{
	}

	protected override void UpdateTxtReachLevel()
	{
	}

	protected override void UpdateNewBestUI()
	{
	}

	protected override bool IsShowNewBestUI()
	{
		return false;
	}

	protected override void OnAfterEquipReady()
	{
	}

	protected override float EquipLevelDropRatio(SelfAttributeData attributeData, LocalSave.EquipOne one)
	{
		return 0f;
	}

	protected override void SendGameOver()
	{
	}

	protected void SendGameOverInternal()
	{
	}

	private CEquipmentItem[] GetEquipItems()
	{
		return null;
	}
}
