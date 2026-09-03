using System.Collections.Generic;
using TableTool;

public class CampBattleStageLayerManager : IStageLayerManager
{
	private static CampBattleStageLayerManager _instance;

	private Stage_Level_stagechapterModel.EquipExpDropData stones;

	private Stage_Level_stagechapterModel.EquipExpDropData skillStones;

	public static CampBattleStageLayerManager Instance => null;

	private void InitSkillStones()
	{
	}

	private void InitStones()
	{
	}

	public override int GetEquipMaxDrop()
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

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetSkillStone(EntityType type)
	{
		return null;
	}

	public override int GetSkillStoneMaxDrop()
	{
		return 0;
	}

	public override int GetExp()
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
