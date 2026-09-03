using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class MeadowBattleRobotManager : MeadowBattleStageAreaManager
{
	private Farm_BattleAI battleAI;

	private int minCount;

	private int maxCount;

	private MeadowBattleStageAreaManager stageAreaManager;

	private MeadowBattleMonsterManager monsterManager;

	private List<RandomMonsterVO> generated_Monster_1_List;

	private List<RandomMonsterVO> generated_Monster_2_List;

	private List<RandomMonsterVO> generated_Monster_4_List;

	private List<RobotBirthAreaVO> birthAreaVOList;

	private bool isSelfTeam;

	private RandomPickRobotMonster pick;

	public CreateGridMonster createGridMonster;

	public List<RobotMonsterInfo> RobotMonsterList;

	public List<RobotBirthAreaVO> cloneBirthAreaVOList => null;

	public void Init(MeadowBattleStageAreaManager _stageAreaManager, MeadowBattleMonsterManager _monsterManager, int rankId)
	{
	}

	public override void Clear()
	{
	}

	private void initGeneratedMonsters()
	{
	}

	private void initRobotBirthAreaVOList()
	{
	}

	public void add2RobotMonsterList(RandomMonsterVO rmVO, Vector2Int curAnchorGrid)
	{
	}

	public void initRobotMonsterList()
	{
	}

	private void createGrid4Monsters()
	{
	}

	private void createGrid2Monsters()
	{
	}

	private void createGrid1Monsters()
	{
	}

	private RobotBirthAreaVO createRobotBirthAreaVO(Vector2Int _leftTop, Vector2Int _rightDown)
	{
		return null;
	}

	private void initStageGrids()
	{
	}
}
