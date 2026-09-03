using System;
using System.Collections.Generic;
using DailyActivity;
using TableTool;

public class SailingBagBattleStageLayerManager : IStageLayerManager
{
	private static SailingBagBattleStageLayerManager _instance;

	private Dictionary<int, ILevelData> levels;

	private Stage_Level_stagechapterModel.EquipExpDropData _newPlay125BagCoin;

	private Stage_Level_stagechapterModel.EquipExpDropData _shipUpgradeItem;

	private Stage_Level_stagechapterModel.EquipExpDropData _commonItem;

	public static SailingBagBattleStageLayerManager Instance => null;

	public void InitLevelsData()
	{
	}

	private void InitNewPlay125BagCoin(ShipStage_BagDifficulty data)
	{
	}

	public string[] GetMapAttributes(int levelId, int missionId)
	{
		return null;
	}

	public string[] GetRoomIds(int levelId, int missionId, int count)
	{
		return null;
	}

	public string[] GetRoomIds(int line, int levelId, int missionId, int count)
	{
		return null;
	}

	public long GetDefence(int levelId, int missionId)
	{
		return 0L;
	}

	public override int GetMaxChapter()
	{
		return 0;
	}

	public override int GetCurrentMaxLevel(int chapterIndex)
	{
		return 0;
	}

	public override int GetRealChapterID(int chapterIndex)
	{
		return 0;
	}

	public override int GetAllMaxLevel(int chapterIndex)
	{
		return 0;
	}

	public override bool IsMaxLevel(int chapterIndex, int roomId)
	{
		return false;
	}

	public override string[] GetGoldTurnByChapter(int chapterIndex)
	{
		return null;
	}

	public override int GetTiledID(int chapterIndex)
	{
		return 0;
	}

	public override float GetGoldDropPercent(int layer)
	{
		return 0f;
	}

	public override string GetStyleString(int roomId)
	{
		return null;
	}

	public override int GetStyleID()
	{
		return 0;
	}

	public override float GetScoreRate()
	{
		return 0f;
	}

	public override bool is_wave_room()
	{
		return false;
	}

	public override int waveroom_get_monsterwave()
	{
		return 0;
	}

	public override int waveroom_get_monsterwave_time()
	{
		return 0;
	}

	public override int waveroom_get_bosswave()
	{
		return 0;
	}

	public override int waveroom_get_bosswave_time()
	{
		return 0;
	}

	public override int waveroom_get_monstersurivival_time()
	{
		return 0;
	}

	public override int waveroom_get_bosssurivival_time()
	{
		return 0;
	}

	public override bool random_reborn_ad()
	{
		return false;
	}

	public override int GetRoomGameType()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetNewPlay125BagCoinItem(EntityType type)
	{
		return null;
	}

	public override int GetNewPlay125BagCoinMaxDrop()
	{
		return 0;
	}

	public void InitCommonItem(ShipStage_BagDifficulty data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCommonItem(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCommonItem(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetCommonItemMaxDrop()
	{
		return 0;
	}

	public override string[] GetWaveIDs(int stage, int layer)
	{
		return null;
	}

	public override string[] GetWaveIDs1(int stage, int layer)
	{
		return null;
	}

	public override int[] GetSeveral(int stage, int layer)
	{
		return null;
	}

	public override int[] GetNest(int stage, int layer)
	{
		return null;
	}

	public override int[] GetNestNum(int stage, int layer)
	{
		return null;
	}

	public string[] GetAttributes(int levelId, int missionId)
	{
		return null;
	}

	public override int GetExp()
	{
		return 0;
	}

	private void InitShipUpgradeItem(ShipStage_BagDifficulty data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetShipUpgradeItem(EntityType type)
	{
		return null;
	}

	public override int GetShipUpgradeMaxDrop()
	{
		return 0;
	}

	public float GetActivityHPRatio(int stage)
	{
		return 0f;
	}

	public float GetActivityAttackRatio(int stage)
	{
		return 0f;
	}

	public float GetActivityBodyHitRatio(int stage)
	{
		return 0f;
	}
}
