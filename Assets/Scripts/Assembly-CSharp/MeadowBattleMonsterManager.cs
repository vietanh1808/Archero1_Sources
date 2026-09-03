using System.Collections.Generic;
using MeadowBattle;
using TableTool;
using UnityEngine;

public class MeadowBattleMonsterManager
{
	public Dictionary<int, TeamMemberVO> selfDict;

	public Dictionary<int, TeamMemberVO> enemyDict;

	public Dictionary<int, EntityMonsterBase> selfEntityDict;

	public Dictionary<int, EntityMonsterBase> enemyEntityDict;

	public List<EntityMonsterBase> PlacedMonsterList;

	private int selectedCharId;

	public int CurMonsterPoints => 0;

	public int SelectedCharId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool HasSelectedMonster => false;

	public EntityMonsterBase SelectedMonster => null;

	public MapCreator MapCtrl => null;

	public List<Farm_BattleMonster> MonsterMetaList => null;

	public bool IsFormationChanged => false;

	public void ClearDicts()
	{
	}

	public void Clear()
	{
	}

	public void Init()
	{
	}

	public void AddToPlacedList(EntityMonsterBase monsterEntity)
	{
	}

	public bool IsBeyondPoints(int deltaPoints)
	{
		return false;
	}

	public void RemoveFromPlacedList(EntityMonsterBase monsterEntity)
	{
	}

	public bool IsInPlacedList(EntityMonsterBase monsterEntity)
	{
		return false;
	}

	public List<EntityMonsterBase> GetSelfExactPlacedList()
	{
		return null;
	}

	public int GetSelfCountInPlacedList()
	{
		return 0;
	}

	public void InitMonstersFromServerData(ServerMonsterVO[] list, bool selfTeam)
	{
	}

	public void DebugInitMonstersFromLocalData()
	{
	}

	public void InitMonstersFromLocalData()
	{
	}

	public bool HaveLocalMonster()
	{
		return false;
	}

	public EntityBase CreateMonster(Farm_BattleMonster meta, bool isSelfTeam, int meadowBattleLevel)
	{
		return null;
	}

	private List<int> getSkillList(int monsterId, int star)
	{
		return null;
	}

	private bool isTwoRows(Farm_BattleMonster meta)
	{
		return false;
	}

	public EntityMonsterBase getEntityByCharId(bool isSelfTeam, int charId)
	{
		return null;
	}

	public void AddMonsterFromLocal(Farm_BattleMonster meta, bool isSelfTeam, MonsterLocationData locationData)
	{
	}

	public void AddMonsterToStage(Farm_BattleMonster meta, bool isSelfTeam, Vector2Int anchorGrid, int meadowBattleLevel)
	{
	}

	public void AddMonsterToStageInternal(EntityMonsterBase entity, bool isSelfTeam, Vector2Int anchorGrid)
	{
	}

	private void saveEntity(EntityMonsterBase entity)
	{
	}

	public void deleteMonster(Farm_BattleMonster meta, bool isSelfTeam)
	{
	}

	public bool isMonsterInStage(int charID, bool isSelfTeam)
	{
		return false;
	}

	public Farm_BattleMonster GetBattleMonsterByCharID(int _charID)
	{
		return null;
	}

	public Farm_BattleMonster GetBattleMonsterByMonsterId(int _monsterID)
	{
		return null;
	}

	public void ClearAllEnemiesAlarmCircles()
	{
	}

	public void OnStartGame()
	{
	}

	public bool CheckIfHaveBonusMonster()
	{
		return false;
	}

	public int GetHPSliderID(EntityBase entity)
	{
		return 0;
	}

	public EntityMonsterBase GetMonsterInStage(int charId, bool isSelfTeam = true)
	{
		return null;
	}

	public bool HasNoMonsterInStage()
	{
		return false;
	}

	public uint[] GetCurrentMonsterIds(int teamId)
	{
		return null;
	}

	public MeadowBattleMonsterInfo.MonsterLocationInfo getMonsterLocationInfo(int charId, int row, int col)
	{
		return null;
	}

	private MeadowBattleMonsterInfo.BodyAreaGrids GetAreaGrids(int charID = 0)
	{
		return (MeadowBattleMonsterInfo.BodyAreaGrids)0;
	}

	public DC_TeamInfo GetDC_TeamInfo(int teamId)
	{
		return null;
	}
}
