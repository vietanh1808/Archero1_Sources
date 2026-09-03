using System.Collections.Generic;
using UnityEngine;

public class TDAreaVO
{
	public bool TDAreaDebug;

	public static int INSIDE_GRASS_RADIUS;

	public static int OUTSIDE_GRASS_RADIUS;

	public Vector2Int AnchorXY;

	public EntityBase m_Entity;

	public int Radius;

	public Vector2Int LeftTop;

	private Vector4 searchVO;

	private List<GameObject> cacheAlarmCicles;

	public List<Vector2Int> RadarGridList;

	private string updateName;

	public Vector2Int EntityArea;

	public Vector2Int TotalArea;

	public Vector3 CenterPos;

	public TDAreaVO(Vector2Int XY, int radius, Vector2Int? area = null, bool areaDebug = true)
	{
	}

	public TDAreaVO(Vector3 wPos, int radius, Vector2Int? area = null, bool areaDebug = true)
	{
	}

	public TDAreaVO(EntityBase entity, int radius, Vector2Int? area = null, bool areaDebug = true)
	{
	}

	public void DeInit()
	{
	}

	public void ResetRadius(int radius)
	{
	}

	private Vector4 GetSearchVO(int radius)
	{
		return default;
	}

	private void createDebugCircles()
	{
	}

	private void syncDebugCircles()
	{
	}

	private void clearDebugCircles()
	{
	}

	private void UpdateTDGridList(Vector2Int _entityXY, Vector4 _searchVO)
	{
	}
}
