using System.Collections.Generic;
using UnityEngine;

public class MeadowBattleStageAreaManager
{
	public Vector2Int leftTop;

	public Vector2Int rightDown;

	public Vector3 leftTopPos;

	public Vector3 rightDownPos;

	private MapCreator mapCreator;

	public List<StageGridVO> stageGrids;

	public int MIN_STAGE_COL => 0;

	public int MAX_STAGE_COL => 0;

	public int MIN_STAGE_ROW => 0;

	public int MAX_STAGE_ROW => 0;

	public void Init()
	{
	}

	public virtual void Clear()
	{
	}

	public void ClearAllGrids()
	{
	}

	public void ResetAllGrids()
	{
	}

	public void OnUpdate()
	{
	}

	public bool IsOusideStageArea(Vector3 pos)
	{
		return false;
	}

	public bool IsOutsideStageArea(Vector2Int pos)
	{
		return false;
	}

	public List<Vector2Int> GetOutlineBodyAreaGrids(EntityMonsterBase entity)
	{
		return null;
	}

	public List<Vector2Int> GetSnapAreaGrids(EntityMonsterBase entity)
	{
		return null;
	}

	private float getDistanceFromEntity(EntityMonsterBase entity, Vector2Int a)
	{
		return 0f;
	}

	public List<StageGridVO> GetCorrespondingStageGrids(List<Vector2Int> _list)
	{
		return null;
	}

	public bool CanBePlacedInStageArea(List<Vector2Int> bodyAreaGrids)
	{
		return false;
	}

	public void RefreshStageAreaByMonster(EntityMonsterBase entity)
	{
	}

	public void DisableStageGrids(List<Vector2Int> forbiddenAreaGrids)
	{
	}

	public void RefreshStageArea()
	{
	}

	public Vector2Int MirrorGrid(Vector2Int _anchorGrid, MeadowBattleMonsterInfo.BodyAreaGrids _bodyAreaGrids)
	{
		return default;
	}
}
