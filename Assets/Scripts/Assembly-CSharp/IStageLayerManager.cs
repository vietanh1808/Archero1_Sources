using System;
using System.Collections.Generic;
using TableTool;

public abstract class IStageLayerManager
{
	public const int MONSTER_WAVE_COUNT_INDEX = 0;

	public const int MONSTER_WAVE_TIME_INDEX = 1;

	public const int BOSS_WAVE_COUNT_INDEX = 2;

	public const int BOSS_WAVE_TIME_INDEX = 3;

	public const int MONSTER_WAVE_SURVIVAL_TIME_INDEX = 4;

	public const int BOSS_WAVE_SURVIVAL_TIME_INDEX = 5;

	public const int DEFAULT_STYLE_ID = 1;

	public const string DEFAULT_STYLE_SEQUENCE = "0101";

	public bool IsWaveRoomInternal()
	{
		return false;
	}

	public virtual string[] GetWaveIDs(int stage, int layer)
	{
		return null;
	}

	public virtual string[] GetWaveIDs1(int stage, int layer)
	{
		return null;
	}

	public virtual int[] GetSeveral(int stage, int layer)
	{
		return null;
	}

	public virtual int[] GetNest(int stage, int layer)
	{
		return null;
	}

	public virtual int[] GetNestNum(int stage, int layer)
	{
		return null;
	}

	public abstract int GetMaxChapter();

	public virtual int GetMaxChapter(GameMode mode)
	{
		return 0;
	}

	public abstract int GetAllMaxLevel(int chapterIndex);

	public abstract int GetCurrentMaxLevel(int chapterIndex);

	public abstract bool IsMaxLevel(int chapterIndex, int roomId);

	public abstract int GetRealChapterID(int chapterIndex);

	public abstract string[] GetGoldTurnByChapter(int chapterIndex);

	public abstract int GetTiledID(int chapterIndex);

	public abstract float GetGoldDropPercent(int layer);

	public abstract int GetStyleID();

	public abstract string GetStyleString(int roomId);

	public abstract float GetScoreRate();

	public virtual int GetExp()
	{
		return 0;
	}

	public virtual int GetEquipMinDrop()
	{
		return 0;
	}

	public virtual int GetEquipMaxDrop()
	{
		return 0;
	}

	public virtual int GetMPMaxDrop()
	{
		return 0;
	}

	public virtual int GetEquipDropID(int chapterId)
	{
		return 0;
	}

	public virtual int GetEquipDropRate(int chapterId)
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetScroll(EntityType type)
	{
		return null;
	}

	public virtual int GetScrollMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
	{
		return null;
	}

	public virtual int GetRuneStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAdventureCoins(EntityType type)
	{
		return null;
	}

	public virtual int GetAdventureCoinsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupeRandData(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupeRandData(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetLoupeMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetStoneMaxDrop()
	{
		return 0;
	}

	public virtual int GetBloodStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetSkillStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetSkillStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetSkillStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFetterBadge(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFetterBadge(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetFetterBadgeMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCommonItem(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCommonItem(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetCommonItemMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetAct4thItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetAct4thExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWishCoin(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWishCoin(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetWishCoinMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetActivityProp(EntityType type)
	{
		return null;
	}

	public virtual int GetActivityPropMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetCookieMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetSoulStone(EntityType type)
	{
		return null;
	}

	public virtual int GetSoulStoneMaxDrop()
	{
		return 0;
	}

	public virtual int GetHonorStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetBone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetBone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetBoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetHorn(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetHorn(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetHornMaxDrop()
	{
		return 0;
	}

	public virtual int GetJewelDropID()
	{
		return 0;
	}

	public virtual int GetJewelRate()
	{
		return 0;
	}

	public virtual int GetJewelDropRateRateMax()
	{
		return 0;
	}

	public virtual float GetSoulPointRate()
	{
		return 0f;
	}

	public virtual int GetSoulPointMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetMagicStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetMagicStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetMagicStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetDragonCoin(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetDragonCoin(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetDragonCoinMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetStarLightStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetStarLightStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetStarLightStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetModstone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetModstone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetModstoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetManorMat(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetManorMat(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetManorMatMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUse(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUse(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetFountainUseMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUpgrade(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFountainUpgrade(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetFountainUpgradeMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetEquipQuintessenceItem(EntityType type)
	{
		return null;
	}

	public virtual int GetEquipQuintessenceMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetChineseKnot(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetChineseKnot(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetChineseKnotMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFirecracker(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFirecracker(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetFirecrackerMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetLevelUpItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetPetLevelUpItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetPetExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetArtifactExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetArtifactExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetArtifactExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintLevelUpItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetImprintLevelUpItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetImprintExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintStoneItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintStoneItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetImprintStoneItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPropById(EntityType type, int equipId)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPropById(EntityType type, int equipId, Func<float> func)
	{
		return null;
	}

	public virtual int GetPropMaxDropById(int id)
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWingLevelUpItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWingLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetWingLevelUpItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct5DonateItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct5DonateItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetAct5DonateItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetNewPlay125BagCoinItem(EntityType type)
	{
		return null;
	}

	public virtual int GetNewPlay125BagCoinMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetShipUpgradeItem(EntityType type)
	{
		return null;
	}

	public virtual int GetShipUpgradeMaxDrop()
	{
		return 0;
	}

	public abstract bool is_wave_room();

	public abstract int waveroom_get_monsterwave();

	public abstract int waveroom_get_monsterwave_time();

	public abstract int waveroom_get_bosswave();

	public abstract int waveroom_get_bosswave_time();

	public abstract int waveroom_get_monstersurivival_time();

	public abstract int waveroom_get_bosssurivival_time();

	public abstract bool random_reborn_ad();

	public abstract int GetRoomGameType();
}
