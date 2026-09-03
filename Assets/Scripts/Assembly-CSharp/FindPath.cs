using System.Collections.Generic;
using UnityEngine;

public class FindPath
{
	private Grid grid;

	private Queue<GameObject> mCacheList;

	private List<GameObject> mUseList;

	public void DeInit()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void InitData()
	{
	}

	public void Init(int[,] rects)
	{
	}

	public List<Grid.NodeItem> FindingPath(Vector3 s, Vector3 e)
	{
		return null;
	}

	private List<Grid.NodeItem> generatePath(Grid.NodeItem startNode, Grid.NodeItem endNode)
	{
		return null;
	}

	private int getDistanceNodes(Grid.NodeItem a, Grid.NodeItem b)
	{
		return 0;
	}

	private GameObject GetSphere()
	{
		return null;
	}

	private void CacheSphere(GameObject o)
	{
	}
}
