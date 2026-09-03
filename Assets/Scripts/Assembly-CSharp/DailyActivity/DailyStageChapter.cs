using System;
using System.Collections.Generic;
using TableTool;

namespace DailyActivity
{
	public class DailyStageChapter : IStageLayerManager
	{
		public static IStageLayerManager Instance;

		private static int DailyStageChapterType;

		private IDailyLevelsManager dailyDataMgr;

		private Dictionary<int, int> maxLayer;

		private Stage_Level_stagechapterModel.EquipExpDropData equipExp;

		private Stage_Level_stagechapterModel.EquipExpDropData stones;

		private Stage_Level_stagechapterModel.EquipExpDropData cookies;

		private Stage_Level_stagechapterModel.EquipExpDropData mRuneStones;

		private Stage_Level_stagechapterModel.EquipExpDropData mSoulStones;

		private Stage_Level_stagechapterModel.EquipExpDropData activityProp;

		private Stage_Level_stagechapterModel.EquipExpDropData mAdventureCoins;

		private Stage_Level_stagechapterModel.EquipExpDropData mLoupe;

		private Stage_Level_stagechapterModel.EquipExpDropData mBone;

		private Stage_Level_stagechapterModel.EquipExpDropData mHorn;

		private Stage_Level_stagechapterModel.EquipExpDropData mBloodStone;

		private Stage_Level_stagechapterModel.EquipExpDropData mFetterBadge;

		private Stage_Level_stagechapterModel.EquipExpDropData mAct4thItems;

		private Stage_Level_stagechapterModel.EquipExpDropData mAct4thExchangeItems;

		private Stage_Level_stagechapterModel.EquipExpDropData mWishCoin;

		private Stage_Level_stagechapterModel.EquipExpDropData mModstone;

		private Stage_Level_stagechapterModel.EquipExpDropData mCommonItem;

		private Stage_Level_stagechapterModel.EquipExpDropData equipQuintessence;

		private Stage_Level_stagechapterModel.EquipExpDropData newPlay125BagCoin;

		private int[] _ids;

		private Stage_Level_stagechapterModel.EquipExpDropData mMagicStone;

		private Stage_Level_stagechapterModel.EquipExpDropData mDragonCoin;

		private Stage_Level_stagechapterModel.EquipExpDropData mManorMat;

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

		private Dictionary<int, Stage_Level_stagechapterModel.EquipExpDropData> m_dicCommonDropConfigs;

		public static void UpdateInstance()
		{
		}

		static DailyStageChapter()
		{
		}

		private void InitEquipExp(Daily_DailyChapter data)
		{
		}

		private void InitActivityProp(Daily_DailyChapter data)
		{
		}

		private void InitStones(Daily_DailyChapter data)
		{
		}

		private void init_runeStone(Daily_DailyChapter data)
		{
		}

		private void init_cookies(Daily_DailyChapter data)
		{
		}

		private void init_soulStone(Daily_DailyChapter data)
		{
		}

		private void init_AdventureCoins(Daily_DailyChapter data)
		{
		}

		public override int GetAllMaxLevel(int chapterIndex)
		{
			return 0;
		}

		public override int GetCurrentMaxLevel(int chapterIndex)
		{
			return 0;
		}

		public int GetChapterByAllLayer(uint modeCode, string extraInfo, out Daily_DailyChapter bean)
		{
			bean = null;
			return 0;
		}

		public override float GetGoldDropPercent(int layer)
		{
			return 0f;
		}

		public override string[] GetGoldTurnByChapter(int chapterIndex)
		{
			return null;
		}

		public override int GetMaxChapter()
		{
			return 0;
		}

		public override int GetRealChapterID(int chapterIndex)
		{
			return 0;
		}

		public override int GetStyleID()
		{
			return 0;
		}

		public override string GetStyleString(int roomId)
		{
			return null;
		}

		protected virtual string[] OnGetStyleString(string[] styleStr)
		{
			return null;
		}

		private string GetStyleStringInternal(string[] styleStr, int roomId)
		{
			return null;
		}

		public override int GetTiledID(int chapterIndex)
		{
			return 0;
		}

		public override bool IsMaxLevel(int chapterIndex, int roomId)
		{
			return false;
		}

		public override float GetScoreRate()
		{
			return 0f;
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

		public override int GetExp()
		{
			return 0;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetScroll(EntityType type)
		{
			return null;
		}

		public override int GetScrollMaxDrop()
		{
			return 0;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetStone(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type, Func<float> func)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetSoulStone(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAdventureCoins(EntityType type)
		{
			return null;
		}

		public override int GetAdventureCoinsMaxDrop()
		{
			return 0;
		}

		private void init_Loupe(Daily_DailyChapter data)
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

		private void InitBone(Daily_DailyChapter data)
		{
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

		private void InitHorn(Daily_DailyChapter data)
		{
		}

		public void InitBloodStone(Daily_DailyChapter data)
		{
		}

		public void InitFetterBadge(Daily_DailyChapter data)
		{
		}

		public void InitAct4thItems(Daily_DailyChapter data)
		{
		}

		public void InitAct4thExchangeItems(Daily_DailyChapter data)
		{
		}

		public void InitWishCoin(Daily_DailyChapter item)
		{
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

		public override int GetRuneStoneMaxDrop()
		{
			return 0;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetActivityProp(EntityType type)
		{
			return null;
		}

		public override int GetActivityPropMaxDrop()
		{
			return 0;
		}

		public override int GetStoneMaxDrop()
		{
			return 0;
		}

		public override int GetCookieMaxDrop()
		{
			return 0;
		}

		public override int GetSoulStoneMaxDrop()
		{
			return 0;
		}

		public override int GetHonorStoneMaxDrop()
		{
			return 0;
		}

		public override int GetEquipDropID(int chapterId)
		{
			return 0;
		}

		public override int GetEquipDropRate(int chapterId)
		{
			return 0;
		}

		public override int GetEquipMinDrop()
		{
			return 0;
		}

		public override int GetEquipMaxDrop()
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

		public override bool is_wave_room()
		{
			return false;
		}

		public override int GetRoomGameType()
		{
			return 0;
		}

		public override bool random_reborn_ad()
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

		private int getWaveInfo(int index)
		{
			return 0;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type, Func<float> func)
		{
			return null;
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

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetWishCoin(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetWishCoin(EntityType type, Func<float> func)
		{
			return null;
		}

		public override int GetWishCoinMaxDrop()
		{
			return 0;
		}

		private void InitMagicStone(Daily_DailyChapter bean)
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

		private void InitDragonCoin(Daily_DailyChapter bean)
		{
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetDragonCoin(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetDragonCoin(EntityType type, Func<float> func)
		{
			return null;
		}

		public override int GetDragonCoinMaxDrop()
		{
			return 0;
		}

		public void InitModstone(Daily_DailyChapter data)
		{
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetModstone(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetModstone(EntityType type, Func<float> func)
		{
			return null;
		}

		public override int GetModstoneMaxDrop()
		{
			return 0;
		}

		public void InitManorMat(Daily_DailyChapter data)
		{
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetManorMat(EntityType type)
		{
			return null;
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetManorMat(EntityType type, Func<float> func)
		{
			return null;
		}

		public override int GetManorMatMaxDrop()
		{
			return 0;
		}

		public void InitFountainUse(Daily_DailyChapter data)
		{
		}

		public void InitFountainUpgrade(Daily_DailyChapter data)
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

		public void InitCommonItem(Daily_DailyChapter data)
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

		private void InitEquipQuintessence(Daily_DailyChapter data)
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

		private void initChineseKnot(Daily_DailyChapter data)
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

		private void initFirecracker(Daily_DailyChapter data)
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

		public void InitLevelUpItems(Daily_DailyChapter data)
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

		public void InitExchangeItems(Daily_DailyChapter data)
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

		public void InitArtifactExchangeItems(Daily_DailyChapter data)
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

		private void InitImprintLevelUpItems(Daily_DailyChapter data)
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

		private void InitImprintExchangeItems(Daily_DailyChapter data)
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

		private void InitImprintStoneItems(Daily_DailyChapter data)
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

		private void InitWingLevelUpItems(Daily_DailyChapter data)
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

		private void InitNewPlay125BagCoin(Daily_DailyChapter data)
		{
		}

		public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetNewPlay125BagCoinItem(EntityType type)
		{
			return null;
		}

		public override int GetNewPlay125BagCoinMaxDrop()
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
}
