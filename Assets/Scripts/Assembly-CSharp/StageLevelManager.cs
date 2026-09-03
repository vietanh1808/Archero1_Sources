using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class StageLevelManager : IStageLayerManager
{
	private Dictionary<int, int> mMaxLayers;

	private int maxChapter;

	private int styleid;

	private static StageLevelManager _instance;

	private Stage_Level_stagechapterModel.EquipExpDropData mEquipExp;

	private Stage_Level_stagechapterModel.EquipExpDropData mRuneStones;

	private Stage_Level_stagechapterModel.EquipExpDropData activityProp;

	private Stage_Level_stagechapterModel.EquipExpDropData mCookies;

	private List<Stage_Level_stagechapterModel.EquipExpRandData> emptySpulStoneData;

	private Stage_Level_stagechapterModel.EquipExpDropData mStones;

	private Stage_Level_stagechapterModel.EquipExpDropData mBloodStones;

	private Stage_Level_stagechapterModel.EquipExpDropData mFetterBadges;

	private Stage_Level_stagechapterModel.EquipExpDropData mAct4thItems;

	private Stage_Level_stagechapterModel.EquipExpDropData mAct4thExchangeItems;

	private Stage_Level_stagechapterModel.EquipExpDropData equipQuintessence;

	private Stage_Level_stagechapterModel.EquipExpDropData mMagicStone;

	private Stage_Level_stagechapterModel.EquipExpDropData mStarLightStone;

	private Stage_Level_stagechapterModel.EquipExpDropData mFountainUse;

	private Stage_Level_stagechapterModel.EquipExpDropData mFountainUpgrade;

	private Stage_Level_stagechapterModel.EquipExpDropData mChineseKnot;

	private Stage_Level_stagechapterModel.EquipExpDropData mFirecracker;

	private Stage_Level_stagechapterModel.EquipExpDropData petLevelUpItems;

	private Stage_Level_stagechapterModel.EquipExpDropData petExchangeItems;

	private Stage_Level_stagechapterModel.EquipExpDropData artifactExchangeItems;

	private Stage_Level_stagechapterModel.EquipExpDropData imprintLevelUpItems;

	private Stage_Level_stagechapterModel.EquipExpDropData imprintExchangeItems;

	private Stage_Level_stagechapterModel.EquipExpDropData imprintStoneItems;

	private Stage_Level_stagechapterModel.EquipExpDropData wingLevelUpItems;

	private Stage_Level_stagechapterModel.EquipExpDropData Act5DonateItems;

	private Dictionary<int, Stage_Level_stagechapterModel.EquipExpDropData> m_dicCommonDropConfigs;

	public static StageLevelManager Instance => null;

	public void Init()
	{
	}

	public int GetMaxUIChapter()
	{
		return 0;
	}

	public override int GetMaxChapter()
	{
		return 0;
	}

	public override int GetMaxChapter(GameMode mode)
	{
		return 0;
	}

	public int GetMaxChapterByMode(bool ifNormal)
	{
		return 0;
	}

	public int GetAllMaxLevel()
	{
		return 0;
	}

	public int GetChapterByAllLayer(uint modeCode, int allLayer, out Stage_Level_stagechapter bean)
	{
		bean = null;
		return 0;
	}

	public override int GetAllMaxLevel(int chapterId)
	{
		return 0;
	}

	public int GetAllMaxLevel(GameMode mode, int chapterId)
	{
		return 0;
	}

	public int GetAllMaxLevelByMode(bool ifNormal, int chapterId)
	{
		return 0;
	}

	public override int GetCurrentMaxLevel(int chapter)
	{
		return 0;
	}

	public int GetCurrentMaxLevelByMode(bool ifNormal, int chapter)
	{
		return 0;
	}

	public int GetCurrentMaxLevel(GameMode mode, int chapter)
	{
		return 0;
	}

	public string GetNormalChapterFullName(int stageid)
	{
		return null;
	}

	public string GetChapterFullName_Hell(int stageid)
	{
		return null;
	}

	public string GetChapterFullName(int stageid)
	{
		return null;
	}

	public Color GetChapterColor(int stageid)
	{
		return default;
	}

	public int GetStartLevel()
	{
		return 0;
	}

	public bool IsMaxLevel(int roomid)
	{
		return false;
	}

	public override bool IsMaxLevel(int chapterId, int roomid)
	{
		return false;
	}

	public override int GetRealChapterID(int chapter)
	{
		return 0;
	}

	public override string[] GetGoldTurnByChapter(int chapter)
	{
		return null;
	}

	public Stage_Level_stagechapter GetBeanByChapter(int chapter, bool ifNormal)
	{
		return null;
	}

	public Stage_Level_stagechapter GetBeanByChapter(int chapter, GameMode mode)
	{
		return null;
	}

	public Stage_Level_stagechapter GetBeanByChapter(int chapter)
	{
		return null;
	}

	public override int GetTiledID(int chapter)
	{
		return 0;
	}

	public Stage_Level_stagechapter GetCurrentStageLevel()
	{
		return null;
	}

	public string[] GetStageLevelTmxIds(int stage, int layer)
	{
		return null;
	}

	public string[] GetStageLevelTmxIds(int layer)
	{
		return null;
	}

	public string[] GetStageLevelAttributes(int layer)
	{
		return null;
	}

	public string[] GetStageLevelAttributes(int stage, int layer)
	{
		return null;
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

	public string[] GetStageLevelMapAttributes(int stage, int layer)
	{
		return null;
	}

	public string GetStartTmx()
	{
		return null;
	}

	public override float GetGoldDropPercent(int layer)
	{
		return 0f;
	}

	public int GetMonsterDropID()
	{
		return 0;
	}

	public int GetBossDropID()
	{
		return 0;
	}

	public override int GetEquipDropID(int chapterid)
	{
		return 0;
	}

	public override int GetEquipDropRate(int chapterid)
	{
		return 0;
	}

	public override float GetScoreRate()
	{
		return 0f;
	}

	public override int GetEquipMinDrop()
	{
		return 0;
	}

	public override int GetEquipMaxDrop()
	{
		return 0;
	}

	public override int GetMPMaxDrop()
	{
		return 0;
	}

	private void init_equipexp(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetScroll(EntityType type)
	{
		return null;
	}

	public override int GetScrollMaxDrop()
	{
		return 0;
	}

	private void init_runeStone(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
	{
		return null;
	}

	public override int GetRuneStoneMaxDrop()
	{
		return 0;
	}

	private void init_activityprop(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetActivityProp(EntityType type)
	{
		return null;
	}

	public override int GetActivityPropMaxDrop()
	{
		return 0;
	}

	private void init_cookies(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetCookieMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetSoulStone(EntityType type)
	{
		return null;
	}

	public override int GetSoulStoneMaxDrop()
	{
		return 0;
	}

	public override int GetHonorStoneMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBone(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetBoneMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetHorn(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetHorn(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetHornMaxDrop()
	{
		return 0;
	}

	public override int GetJewelDropID()
	{
		return 0;
	}

	public override int GetJewelRate()
	{
		return 0;
	}

	public override int GetJewelDropRateRateMax()
	{
		return 0;
	}

	private void init_stones(Stage_Level_stagechapter data)
	{
	}

	private void init_blood_stones(Stage_Level_stagechapter data)
	{
	}

	private void initFetterBadges(Stage_Level_stagechapter data)
	{
	}

	private void initAct4thItems(Stage_Level_stagechapter data)
	{
	}

	private void initAct4thExchangeItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetStoneMaxDrop()
	{
		return 0;
	}

	public override int GetBloodStoneMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFetterBadge(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFetterBadge(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetFetterBadgeMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetAct4thItemsMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thExchangeItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetAct4thExchangeItemsMaxDrop()
	{
		return 0;
	}

	public override int GetStyleID()
	{
		return 0;
	}

	public override string GetStyleString(int roomid)
	{
		return null;
	}

	private string GetStyleStringInternal(string[] seq, int roomid)
	{
		return null;
	}

	public override int GetExp()
	{
		return 0;
	}

	public int GetFreeGold()
	{
		return 0;
	}

	public override bool is_wave_room()
	{
		return false;
	}

	public override int GetRoomGameType()
	{
		return 0;
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

	public string[] GetStageLevelHellMonsterAttributes(int stage, int layer)
	{
		return null;
	}

	public int GetStageLevelHellEnvironment(int stage, int layer)
	{
		return 0;
	}

	public int[] GetStageLevelHellStageInfos(int stage, int layer)
	{
		return null;
	}

	public long GetStageLevelStandardDefence(int stage, int layer)
	{
		return 0L;
	}

	private void InitMagicStone(Stage_Level_stagechapter bean)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetMagicStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetMagicStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetMagicStoneMaxDrop()
	{
		return 0;
	}

	private void InitStarLightStone(Stage_Level_stagechapter bean)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetStarLightStone(EntityType type)
	{
		return null;
	}

	public new virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetStarLightStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetStarLightStoneMaxDrop()
	{
		return 0;
	}

	public void InitFountainUse(Stage_Level_stagechapter data)
	{
	}

	public void InitFountainUpgrade(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUse(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUse(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetFountainUseMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUpgrade(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUpgrade(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetFountainUpgradeMaxDrop()
	{
		return 0;
	}

	private void initChineseKnot(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetChineseKnot(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetChineseKnot(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetChineseKnotMaxDrop()
	{
		return 0;
	}

	private void initFirecracker(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFirecracker(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetFirecracker(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetFirecrackerMaxDrop()
	{
		return 0;
	}

	private void init_Loupes()
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupeRandData(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupeRandData(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetLoupeMaxDrop()
	{
		return 0;
	}

	private void InitEquipQuintessence(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetEquipQuintessenceItem(EntityType type)
	{
		return null;
	}

	public override int GetEquipQuintessenceMaxDrop()
	{
		return 0;
	}

	private void InitPetLevelUpItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetLevelUpItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetPetLevelUpItemsMaxDrop()
	{
		return 0;
	}

	private void InitPetExchangeItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetExchangeItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetPetExchangeItemsMaxDrop()
	{
		return 0;
	}

	private void InitArtifactExchangeItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetArtifactExchangeItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetArtifactExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetArtifactExchangeItemsMaxDrop()
	{
		return 0;
	}

	private void InitImprintLevelUpItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintLevelUpItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetImprintLevelUpItemsMaxDrop()
	{
		return 0;
	}

	private void InitImprintExchangeItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintExchangeItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetImprintExchangeItemsMaxDrop()
	{
		return 0;
	}

	private void InitImprintStoneItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintStoneItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintStoneItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetImprintStoneItemsMaxDrop()
	{
		return 0;
	}

	private void InitWingLevelUpItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetWingLevelUpItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetWingLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetWingLevelUpItemsMaxDrop()
	{
		return 0;
	}

	private void InitAct5DonateItems(Stage_Level_stagechapter data)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct5DonateItems(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct5DonateItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetAct5DonateItemsMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetPropById(EntityType type, int equipId)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetPropById(EntityType type, int equipId, Func<float> func)
	{
		return null;
	}

	private void InitCommonProp(int id)
	{
	}

	public override int GetPropMaxDropById(int id)
	{
		return 0;
	}
}
