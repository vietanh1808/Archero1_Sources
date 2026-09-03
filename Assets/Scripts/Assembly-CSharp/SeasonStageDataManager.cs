using System.Collections.Generic;
using TableTool;

public class SeasonStageDataManager : IStageLayerManager
{
	private Dictionary<int, Stage_Level_chapter101Model.Stage_LevelData> list;

	private Dictionary<int, int> mMaxLayers;

	private static SeasonStageDataManager _instance;

	public static SeasonStageDataManager Instance => null;

	public void Init()
	{
	}

	public override float GetSoulPointRate()
	{
		return 0f;
	}

	public override int GetSoulPointMaxDrop()
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

	public override string GetStyleString(int roomId)
	{
		return null;
	}

	private string GetStyleStringInternal(string[] seq, int roomid)
	{
		return null;
	}

	private PVEStage_stagechapter GetPveStageData(int chapter)
	{
		return null;
	}

	public override float GetScoreRate()
	{
		return 0f;
	}

	public override bool is_wave_room()
	{
		return false;
	}

	public bool is_wave_room(int chapter)
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

	public string[] GetStageLevel_Attributes(int stage, int level)
	{
		return null;
	}

	public string[] GetStageLevelMapAttributes(int stage, int layer)
	{
		return null;
	}

	public string[] GetStageLevel_RoomIds(int stage, int level, int count)
	{
		return null;
	}

	private bool CheckData(ref int stage, int level)
	{
		return false;
	}

	public long GetStageLevelStandardDefence(int stage, int layer)
	{
		return 0L;
	}

	public PVEStage_stagechapter GetCurrentStageLevel()
	{
		return null;
	}

	public PVEStage_stagechapter GetBeanByChapter(int chapter)
	{
		return null;
	}

	public int GetStage(int stage)
	{
		return 0;
	}
}
