using System.Collections.Generic;
using TableTool;
using XLua;

public class CampTileBossData : CampTileBaseData<CampTileBossConfigData>
{
	private static DelegateBridge __Hotfix0_get_BossBattleStatus;

	private static DelegateBridge __Hotfix0_get_BossBattleState;

	private static DelegateBridge __Hotfix0_get_AttackBossDefenderCamp;

	private static DelegateBridge __Hotfix0_get_Score;

	private static DelegateBridge __Hotfix0_get_Rank;

	private static DelegateBridge __Hotfix0_get_MonsterScore;

	private static DelegateBridge __Hotfix0_get_MonsterNeedValue;

	private static DelegateBridge __Hotfix0_ProgressRewardStatus;

	private static DelegateBridge __Hotfix0_get_ProgressRewards;

	private static DelegateBridge __Hotfix0_get_BossDeadTime;

	private static DelegateBridge __Hotfix0_UpdateBossData;

	private static DelegateBridge __Hotfix0_UpdateRewardProcess;

	private static DelegateBridge __Hotfix0_GetProgressRewardStatus;

	private static DelegateBridge __Hotfix0_GetProgressRewards;

	private static DelegateBridge __Hotfix0_GetMonsterNeedValue;

	private static DelegateBridge __Hotfix0_GetAttackBossDefenderCamp;

	private static DelegateBridge _c__Hotfix0_ctor;

	public BossBattleStatus BossBattleStatus => BossBattleStatus.None;

	public int BossBattleState => 0;

	public CampID AttackBossDefenderCamp => CampID.Unknown;

	public int[] Score => null;

	public int[] Rank => null;

	public int[] MonsterScore => null;

	public int MonsterNeedValue => 0;

	public List<(int, List<Drop_DropModel.DropData>)> ProgressRewards => null;

	public long BossDeadTime => 0L;

	public CampTileRewardStatus ProgressRewardStatus(int index)
	{
		return CampTileRewardStatus.None;
	}

	public void UpdateBossData(int bossStage, int[] bossMonsterOccupyValue, int[] bossCampRank, int[] bossCampScore, long bossDeadTime)
	{
	}

	public void UpdateRewardProcess(int rewardID)
	{
	}

	private CampTileRewardStatus GetProgressRewardStatus(int id)
	{
		return CampTileRewardStatus.None;
	}

	private List<(int, List<Drop_DropModel.DropData>)> GetProgressRewards()
	{
		return null;
	}

	private int GetMonsterNeedValue()
	{
		return 0;
	}

	private CampID GetAttackBossDefenderCamp()
	{
		return CampID.Unknown;
	}
}
