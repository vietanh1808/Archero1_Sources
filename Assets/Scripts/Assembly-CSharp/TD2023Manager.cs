using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class TD2023Manager : CInstance<TD2023Manager>
{
	public enum SelectTargetEnum
	{
		MaxHP = 1,
		LeastHP = 2,
		NearestBase = 3,
		RandomMonster = 4
	}

	public Dictionary<Vector2Int, bool> MineDict;

	public float RewardScorePerMonster;

	public float ExpFactor;

	public float GoldFactor;

	public List<Daily_DefenseTower> towerMetas;

	public List<PVEStage_DefenseTower> seasonTowerMetas;

	public List<int> DailyAlternativeTowerIds;

	public List<int> AlternativeTowerIds;

	public int TOWER_RADIUS;

	public int BIRTH_RADIUS;

	public int BASE_RADIUS;

	public const int STONE_TOWER = 1;

	public const int FLOOR_TOWER = 2;

	public const int SELF_TEAM_ID = 555;

	public const int ENEMY_TEAM_ID = 666;

	public const string LOG_TAG = "[TD2023]";

	public const int TD_ID = 55555;

	public const int TD_BASE_ID = 2017;

	public const int TD_BASE_CHAR_ID = 1830;

	public const int PLAYER_POINT = 1200;

	public const int MOCK_GOOD_ID = 1201;

	public const int ENEMY_POINT_1 = 1201;

	public const int ENEMY_POINT_2 = 1202;

	public const int ENEMY_POINT_3 = 1203;

	public Dictionary<int, Vector3> EnemyPointDict;

	public Dictionary<int, List<Vector2Int>> EmptyGridsDict;

	public List<EntityTD2023Base> TowerList;

	public Vector3 PlayerBirthPos;

	public Vector3 TDBasePos;

	public Vector2Int TDBaseXY;

	public EntityBase TDBaseEntity;

	public List<TDAreaVO> TDAreaVOList;

	public List<TDAreaVO> FloorTDAreaVOList;

	public TD2023MonsterWaveController waveController;

	public TD2023DataAnalytic dc;

	public TDSeasonVIP SeasonVIP;

	private const int CONFIG_ID = 3214;

	public float SqrAbsorbRadius;

	public float AbsorbRadius;

	public float MonsterColliderRadius;

	public float BossColliderRadius;

	public bool CanCustomMonsterRadius;

	public Dictionary<string, List<float>> psDict;

	private HashSet<int> existingRangeIndicators;

	private AssistHeroController _assistHeroCtrl;

	public int CurTDLevelId => 0;

	public int CurDailyChapterId => 0;

	public int CurWaveId => 0;

	public Daily_DailyChapter CurDailyChapterData => null;

	public Tower_Defense_TDlevel CurTDLevelData => null;

	public Daily_TDlevel CurDailyTDLevelData => null;

	public PVEStage_stagechapter CurSeasonTDLevelData => null;

	public AssistHeroController AssistHeroCtrl => null;

	public new void Init()
	{
	}

	private void initRewardScore()
	{
	}

	public bool IsLockedSelectedTower(int towerId)
	{
		return false;
	}

	public void SetDailyAlternativeTowerIds(List<int> ids)
	{
	}

	private void initTowers()
	{
	}

	private void initSeasonTowers()
	{
	}

	public Daily_DefenseTower GetTowerMetaByIndex(int index)
	{
		return null;
	}

	public PVEStage_DefenseTower GetSeasonTowerMetaByIndex(int index)
	{
		return null;
	}

	public void InitFactors()
	{
	}

	public void DeInit()
	{
	}

	private void initRadius()
	{
	}

	private void initColliderRadius()
	{
	}

	public bool IsPoint(int goodId)
	{
		return false;
	}

	public void StartWave()
	{
	}

	public void SetAlternativeTowerIds(List<int> list)
	{
	}

	public void UpdateEnemyPointDict(int key, Vector3 wPos)
	{
	}

	public int GetTowerType(int towerId)
	{
		return 0;
	}

	public EntityTD2023Base CreateTower(int towerId, Vector2Int colRow, int towerLevel = 1, List<int> learnedSkillIds = null, List<int> NextLevelSkillIds = null)
	{
		return null;
	}

	public EntityBase CreateMonster(int monsterId, Vector3 birthPos)
	{
		return null;
	}

	public TDAreaVO FindTDAreaVO(Vector2Int XY)
	{
		return null;
	}

	public TDAreaVO FindFloorTDAreaVO(Vector2Int XY)
	{
		return null;
	}

	public bool CanCreateTD(Vector2Int XY)
	{
		return false;
	}

	public bool CanCreateFloorTD(Vector2Int XY)
	{
		return false;
	}

	public bool IsObstacle(int towerType)
	{
		return false;
	}

	public TDAreaVO CreateTDAreaVO(Vector2Int XY, int radius, Vector2Int? area = null)
	{
		return null;
	}

	public TDAreaVO CreateTDAreaVO(Vector3 wPos, int radius, Vector2Int? area = null)
	{
		return null;
	}

	public TDAreaVO CreateTDAreaVO(EntityBase entity, int radius, Vector2Int? area = null)
	{
		return null;
	}

	public TDAreaVO CreateFloorTDAreaVO(Vector2Int XY, int radius, Vector2Int? area = null)
	{
		return null;
	}

	public TDAreaVO CreateFloorTDAreaVO(Vector3 wPos, int radius, Vector2Int? area = null)
	{
		return null;
	}

	public TDAreaVO CreateFloorTDAreaVO(EntityBase entity, int radius, Vector2Int? area = null)
	{
		return null;
	}

	public bool IsTDGameOver()
	{
		return false;
	}

	public bool IsTDBaseDead()
	{
		return false;
	}

	public void AddTower(EntityTD2023Base tower)
	{
	}

	public EntityTD2023Base GetTower(int instanceId)
	{
		return null;
	}

	public bool HasTower(EntityTD2023Base tower)
	{
		return false;
	}

	public List<Vector3> GetEnemyBirthPosList()
	{
		return null;
	}

	public bool HasReachMaxTower()
	{
		return false;
	}

	public int GetTotalTowerCount()
	{
		return 0;
	}

	public int GetTowerCount(int type)
	{
		return 0;
	}

	public void CreateEnemyBirthEffect(Vector3 pos)
	{
	}

	public void SaveFinishedWave(int curWaveId)
	{
	}

	public void OnCurWaveFinished(int curWaveId)
	{
	}

	public void ShowRange(int instanceId, Vector3 pos, Vector2 range)
	{
	}

	public void HideRange(int instanceId)
	{
	}

	public void SendGameOver()
	{
	}

	public void NotifyBattleGameOverWrapper()
	{
	}

	public Dictionary<int, Tower_Defense_Wave101Model.LevelWaveData> GetLevelWaveDict()
	{
		return null;
	}

	public PVEStage_StageRatio GetStageRatioByStageId(int curNormalStage)
	{
		return null;
	}

	public int GetTotalWaves()
	{
		return 0;
	}

	public int GetTotalWaves(bool isWin)
	{
		return 0;
	}

	public string GetAlternativeTowerStr()
	{
		return null;
	}

	public string GetDailyAlternativeTowerStr()
	{
		return null;
	}

	public int GetEnergy()
	{
		return 0;
	}

	public int GetTDStone()
	{
		return 0;
	}

	public int GetTDMax()
	{
		return 0;
	}

	public int GetExpBase()
	{
		return 0;
	}

	public int GetExpAdd()
	{
		return 0;
	}

	public float GetIntegralRate()
	{
		return 0f;
	}

	public int GetFinishedWaveId(bool ifWin)
	{
		return 0;
	}

	public int GetUpgradeCost(PVEStage_DefenseTower seasonConfig, int tdLevel)
	{
		return 0;
	}

	public int GetExtraTDCoin()
	{
		return 0;
	}

	public float GetRecoverHPPercent()
	{
		return 0f;
	}

	public int GetSeasonTDBuildCost(PVEStage_DefenseTower seasonConfig)
	{
		return 0;
	}

	internal bool IsSeasonTowerVip(PVEStage_DefenseTower seasonConfig)
	{
		return false;
	}

	private void createTowerHelpPet()
	{
	}

	public void InitAssistHero()
	{
	}

	public void DeInitAssistHero()
	{
	}
}
