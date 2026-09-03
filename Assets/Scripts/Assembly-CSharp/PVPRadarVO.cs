using System.Collections.Generic;
using UnityEngine;

public class PVPRadarVO
{
	private bool RadarDebug;

	private const string UPDATE_NAME = "PVPRadarVO";

	public static int INSIDE_GRASS_RADIUS;

	public static int OUTSIDE_GRASS_RADIUS;

	public Vector2Int AnchorXY;

	public EntityNetHero m_Entity;

	public int Radius;

	public Vector2Int LeftTop;

	private Vector4 searchVO;

	private List<GameObject> cacheAlarmCicles;

	public List<Vector2Int> RadarGridList;

	private string updateName;

	public List<Vector2Int> GridList => null;

	public PVPRadarVO(EntityNetHero entity, int radius)
	{
	}

	public void DeInit()
	{
	}

	public void ResetRadius(int radius)
	{
	}

	public void Update(float delta)
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

	private void UpdateRadarGridList(Vector2Int _entityXY, Vector4 _searchVO)
	{
	}
}
