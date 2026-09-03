using System.Collections.Generic;
using TableTool;

public class EventTowerLevelManager : IStageLayerManager
{
	public class DifficultyData
	{
		public int EventTowerId;

		public int EventTowerDifficulty;

		public string[] MapAttributesUp;

		public string[] AttributesUp;

		public string[] SuccessRewards;

		public string[] FailRewards;

		public float HeroRate;

		public string[] RoomIDs;

		public DifficultyData(int id, int difficulty)
		{
		}
	}

	public const string LOG_TAG = "[EventTower]";

	private Tower_EventTowerConfigModel eventTowerConfig;

	private static EventTowerLevelManager instance;

	private int safeCount;

	private const int MAX_SAFE_COUNT = 1000;

	private int safe2Count;

	public int AlternativeSkillNum => 0;

	public static EventTowerLevelManager Instance => null;

	private int EventTowerId => 0;

	private int EventTowerDifficulty => 0;

	private void Init()
	{
	}

	public List<string> GetMonsterTmxAttributes()
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetAttributesUpDict()
	{
		return null;
	}

	public DifficultyData GetDifficultyData(int eventTowerId, int eventTowerDifficulty)
	{
		return null;
	}

	private int getWaveInfo(int index)
	{
		return 0;
	}

	public bool CanRevival()
	{
		return false;
	}

	public int GetSelectedSkillNum(int eventTowerId)
	{
		return 0;
	}

	public List<int> GetAlternativeSkillIds()
	{
		return null;
	}

	private void populateBlockedSkillDict(Dictionary<int, int> blockedDict)
	{
	}

	private void populateSkillWeightDict(Dictionary<int, TowerLevelManager.SkillWeight> skillWeightDict, Dictionary<int, int> blockedDict, string[] skills, ref int allWeight)
	{
	}

	private List<int> pickSkillsFromSkillWeightDict(Dictionary<int, TowerLevelManager.SkillWeight> skillWeightDict, int allWeight, Dictionary<int, int> dict, Dictionary<int, int> blockedDict)
	{
		return null;
	}

	private void safeLog(int safeCount, string str)
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

	public override int GetRoomGameType()
	{
		return 0;
	}

	public override float GetScoreRate()
	{
		return 0f;
	}

	public override int GetStyleID()
	{
		return 0;
	}

	public override string GetStyleString(int roomId)
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

	public override bool is_wave_room()
	{
		return false;
	}

	public override bool random_reborn_ad()
	{
		return false;
	}

	public override int waveroom_get_bosssurivival_time()
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

	public override int waveroom_get_monsterwave()
	{
		return 0;
	}

	public override int waveroom_get_monsterwave_time()
	{
		return 0;
	}
}
