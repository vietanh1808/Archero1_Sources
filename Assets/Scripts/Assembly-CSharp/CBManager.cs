using System;
using System.Collections.Generic;
using CampBattle;
using GameProtocol;
using TableTool;
using XLua;

public class CBManager : CInstance<CBManager>
{
	public Dictionary<int, RoundMeta> roundDict;

	public SLGStage_stagechapter SLGStageChapterMeta;

	public float SoldierWaveTime;

	public int SoldierWaveCount;

	public float BossWaveTime;

	public int BossWaveCount;

	public int[] SoldierCountRange;

	public float SoldierCountUpPercent;

	public int[] BossCountRange;

	public float KillBossWaitTime;

	public float KillSoldierWaitTime;

	public float RoundWaitTime;

	private static DelegateBridge __Hotfix0_get_AtkStart;

	private static DelegateBridge __Hotfix0_set_AtkStart;

	private static DelegateBridge __Hotfix0_get_HpStart;

	private static DelegateBridge __Hotfix0_set_HpStart;

	private static DelegateBridge __Hotfix0_get_AtkEnd;

	private static DelegateBridge __Hotfix0_set_AtkEnd;

	private static DelegateBridge __Hotfix0_get_HpEnd;

	private static DelegateBridge __Hotfix0_set_HpEnd;

	private static DelegateBridge __Hotfix0_get_SLGStageChapterId;

	private static DelegateBridge __Hotfix0_get_MaxRound;

	private static DelegateBridge __Hotfix0_set_MaxRound;

	private static DelegateBridge __Hotfix0_get_RoundTime;

	private static DelegateBridge __Hotfix0_set_RoundTime;

	private static DelegateBridge __Hotfix0_Initialize;

	private static DelegateBridge __Hotfix0_DeInit;

	private static DelegateBridge __Hotfix0_get_BattleType;

	private static DelegateBridge __Hotfix0_get_TileLevel;

	private static DelegateBridge __Hotfix0_GetRoundMeta;

	private static DelegateBridge __Hotfix0_GetStageChapterData;

	private static DelegateBridge __Hotfix0_SaveValuesOnGameEnd;

	private static DelegateBridge __Hotfix0_getMappingBuildType;

	private static DelegateBridge __Hotfix0_GetDifficultyRatio;

	private static DelegateBridge __Hotfix0_OnBattleResponse;

	private static DelegateBridge __Hotfix0_GetBattleNobilityExp;

	private static DelegateBridge __Hotfix0_PopulatePro;

	private static DelegateBridge __Hotfix0_getTeamCampTalentId;

	private static DelegateBridge __Hotfix0_SendGameOver;

	private static DelegateBridge __Hotfix0_printRewardInfo;

	private static DelegateBridge _c__Hotfix0_ctor;

	public long AtkStart { get; set; }

	public long HpStart { get; set; }

	public long AtkEnd { get; set; }

	public long HpEnd { get; set; }

	public int SLGStageChapterId => 0;

	public int MaxRound { get; private set; }

	public float RoundTime { get; private set; }

	public int BattleType => 0;

	public int TileLevel => 0;

	public void Initialize()
	{
	}

	public void DeInit()
	{
	}

	public RoundMeta GetRoundMeta(int roundId)
	{
		return null;
	}

	public SLGStage_stagechapter GetStageChapterData(int seasonId, int level, int buildType)
	{
		return null;
	}

	public void SaveValuesOnGameEnd()
	{
	}

	public int getMappingBuildType(int buildingType)
	{
		return 0;
	}

	public float GetDifficultyRatio()
	{
		return 0f;
	}

	public void OnBattleResponse(string json)
	{
	}

	public int GetBattleNobilityExp(bool isWin)
	{
		return 0;
	}

	public void PopulatePro(Dictionary<string, object> pro)
	{
	}

	private int getTeamCampTalentId()
	{
		return 0;
	}

	public void SendGameOver(bool ifStageComplete, uint getSlgTalent, uint getSlgCampTalent, uint getgold, uint getexp, CEquipmentItem[] arrayEquipItems, Action<CRespCampSeasonBattle> onSuccess)
	{
	}

	private void printRewardInfo(CRespCampSeasonBattle info)
	{
	}
}
