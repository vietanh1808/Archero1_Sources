using System;
using System.Collections.Generic;
using TableTool;

public class TryPlayManager : IStageLayerManager
{
	public class TryPlayData
	{
		private const string cfileName = "jsonData/TryPlayData";

		public string styleStr;

		public string tmxFile;

		public int monsterwave_time;

		public int monsterwave;

		public int rebornCount;

		public int styleId { get; private set; }

		public void Load()
		{
		}
	}

	private static TryPlayManager _instance;

	private TryPlayData tryplayData;

	public static TryPlayManager Instance => null;

	private void Init()
	{
	}

	public string GetTmxFIle()
	{
		return null;
	}

	public int GetRebornCount()
	{
		return 0;
	}

	public string[] GetMapAttributes(int id)
	{
		return null;
	}

	public string[] GetTmxIds(int id)
	{
		return null;
	}

	public string[] GetMonsterTmxAttributes(int id)
	{
		return null;
	}

	public int GetRoomsCount()
	{
		return 0;
	}

	public override int GetMaxChapter()
	{
		return 0;
	}

	public override int GetAllMaxLevel(int chapterIndex)
	{
		return 0;
	}

	public override int GetCurrentMaxLevel(int chapterIndex)
	{
		return 0;
	}

	public override bool IsMaxLevel(int chapterIndex, int roomId)
	{
		return false;
	}

	public override int GetRealChapterID(int chapterIndex)
	{
		return 0;
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

	public override int GetStyleID()
	{
		return 0;
	}

	public override string GetStyleString(int roomid)
	{
		return null;
	}

	public int[] GetTowerEvents(int id)
	{
		return null;
	}

	public List<int> GetTowerSkills(int id)
	{
		return null;
	}

	public int GetCanLearnSkillNum(int id)
	{
		return 0;
	}

	public override float GetScoreRate()
	{
		return 0f;
	}

	public override int GetExp()
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

	public override int GetEquipDropID(int chapterId)
	{
		return 0;
	}

	public override int GetEquipDropRate(int chapterId)
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

	public override int GetStoneMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
	{
		return null;
	}

	public override int GetRuneStoneMaxDrop()
	{
		return 0;
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

	private int getWaveInfo(int index)
	{
		return 0;
	}

	public override bool random_reborn_ad()
	{
		return false;
	}

	public List<int> GetSkill6()
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetActivityProp(EntityType type)
	{
		return null;
	}

	public override int GetActivityPropMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAdventureCoins(EntityType type)
	{
		return null;
	}

	public override int GetAdventureCoinsMaxDrop()
	{
		return 0;
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
}
