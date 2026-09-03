using XLua;

public class CampTileBossConfigData : CampTileBaseConfigData
{
	public int[] score;

	public int[] rank;

	public int progressRewardsStatus;

	public int[] monsterScore;

	public int bossBattleState;

	public long bossDeadTime;

	private static DelegateBridge __Hotfix0_SetProgressData;

	private static DelegateBridge __Hotfix0_SetRankData;

	private static DelegateBridge __Hotfix0_SetMonsterData;

	private static DelegateBridge __Hotfix0_UpdateBossData;

	private static DelegateBridge __Hotfix0_UpdateRewardProcess;

	private static DelegateBridge _c__Hotfix0_ctor;

	public CampTileBossConfigData SetProgressData(int bossBattleState, int progressRewardsStatus, long bossDeadTime)
	{
		return null;
	}

	public CampTileBossConfigData SetRankData(uint[] score, ushort[] rank)
	{
		return null;
	}

	public CampTileBossConfigData SetMonsterData(uint[] monsterScore)
	{
		return null;
	}

	public void UpdateBossData(int bossStage, int[] bossMonsterOccupyValue, int[] bossCampRank, int[] bossCampScore, long bossDeadTime)
	{
	}

	public void UpdateRewardProcess(int rewardID)
	{
	}
}
