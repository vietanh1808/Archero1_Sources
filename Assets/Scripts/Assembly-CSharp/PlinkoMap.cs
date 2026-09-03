using System;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoMap : MonoBehaviour
{
	private Dictionary<int, List<PlinkoCylinderData>> _map;

	public GameObject cylindersRoot;

	[HideInInspector]
	public List<PlinkoCylinderItem> cylinders;

	public List<Transform> spawnPoints;

	private int testIndex;

	private readonly Vector3 _leftAngle;

	private readonly Vector3 _rightAngle;

	public Dictionary<int, List<PlinkoCylinderData>> Map => null;

	public void initMap()
	{
	}

	public void bindData_cylinder()
	{
	}

	public void clearBalls()
	{
	}

	private void CreateRow(int row, int count)
	{
	}

	public void Clear()
	{
	}

	public void PlayAnimation(PlinkoBallItem ball, PlinkoCylinderItem next, PlinkoMoveInfo data, Action startAction = null, Action endAction = null)
	{
	}

	public void PlayRotateAnimation(PlinkoBallItem ball, bool isLeft, float time)
	{
	}

	public void ResetBall(PlinkoBallItem ball)
	{
	}

	public void ResetBall(PlinkoBallItem ball, Vector3 pos)
	{
	}

	private PlinkoCylinderData GetLeftTopData(int row, int column)
	{
		return null;
	}

	private PlinkoCylinderData GetRightTopData(int row, int column)
	{
		return null;
	}

	private PlinkoCylinderData GetLeftData(int row, int column)
	{
		return null;
	}

	private PlinkoCylinderData GetRightData(int row, int column)
	{
		return null;
	}

	private PlinkoCylinderData GetLeftBottomData(int row, int column)
	{
		return null;
	}

	private PlinkoCylinderData GetRightBottomData(int row, int column)
	{
		return null;
	}

	public LinkedList<PlinkoCylinderData> GeneratePath(int goalIndex)
	{
		return null;
	}

	private LinkedList<PlinkoCylinderData> FindRandomPath(int goalIndex)
	{
		return null;
	}
}
