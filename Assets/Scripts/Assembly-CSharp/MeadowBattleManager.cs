using System;
using System.Collections.Generic;
using MeadowBattle;
using TableTool;
using UnityEngine;

public class MeadowBattleManager : IStageLayerManager
{
	private class MapStyleEnum
	{
		public const int grass = 1;

		public const int desert = 2;

		public const int dungeon = 3;

		public const int mine = 4;
	}

	private bool isBattleStarted;

	private bool initialized;

	private const int COLOR_ID = 1;

	private const int MEADOWN_STYLE_ID = 13;

	private static MeadowBattleManager _instance;

	public PlayerTouch playerTouch;

	public MeadowBattleMonsterManager MonsterManager;

	public MonsterDragManager DragManager;

	public MeadowBattleStageAreaManager StageAreaManager;

	public MeadowBattleRobotManager RobotManager;

	public MeadowBattleGameDataManager GameDataManager;

	public Camera UICamera;

	private Vector3 oldCameraPos;

	public float OldCameraSize;

	public Plane GroundPlane;

	public bool ShowDefensive;

	public MatchVO MatchVO;

	private GameObject goStageBorders;

	private GameObject goEvolutionArea;

	private float displayInterval;

	public float StartTimeStamp { get; set; }

	public float ElapsedTime { get; set; }

	public bool IsAIEnabled { get; set; }

	public bool IsBtnStartClicked { get; set; }

	public bool IsBattleStarted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Initialized
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static MeadowBattleManager Instance => null;

	public Camera Camera => null;

	public void Init()
	{
	}

	public void OnStartGame(Action callback)
	{
	}

	private void DebugRandomRobotFormation(bool useTimer = false)
	{
	}

	public void Clear()
	{
	}

	private void initStageBorders()
	{
	}

	private void clearStageBorders()
	{
	}

	public void SetStageBordersVisible(bool _visible)
	{
	}

	private void initEvolutionArea()
	{
	}

	private void clearEvolutionArea()
	{
	}

	public void SetEvolutionAreaVisible(bool _visible)
	{
	}

	public void PauseGame()
	{
	}

	public void ResumeGame()
	{
	}

	protected void OnUpdate(float delta)
	{
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

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
	{
		return null;
	}

	public override int GetRuneStoneMaxDrop()
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

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetStone(EntityType type)
	{
		return null;
	}

	public override int GetStoneMaxDrop()
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
