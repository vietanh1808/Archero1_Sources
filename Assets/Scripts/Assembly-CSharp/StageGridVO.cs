using UnityEngine;

public class StageGridVO
{
	public enum GridState
	{
		empty = 0,
		snap = 1
	}

	public enum GridCircleState
	{
		attack = 0,
		body = 1,
		outline = 2
	}

	public Vector2Int Pos;

	public bool IsAvailable;

	public int CharID;

	private GridState curGridState;

	private GameObject goOutlineCircle;

	public GridState CurGridState
	{
		get
		{
			return GridState.empty;
		}
		set
		{
		}
	}

	public Vector3 WorldPos => default;

	public StageGridVO(Vector2Int _Pos)
	{
	}

	private GameObject createCircle(string prefabName, Vector2Int _Pos)
	{
		return null;
	}

	public void VisualizeSnapCircle(bool visible)
	{
	}

	public void VisulizeCircle(GridCircleState circleState, bool visible)
	{
	}

	public void SetAllInvisible()
	{
	}

	public void Clear()
	{
	}
}
