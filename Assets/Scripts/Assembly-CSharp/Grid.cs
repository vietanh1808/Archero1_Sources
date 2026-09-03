using System.Collections.Generic;
using UnityEngine;

public class Grid
{
	public class NodeItem
	{
		public enum NodeType
		{
			none = 0,
			open = 1,
			close = 2
		}

		public NodeType pathType;

		public bool isWall;

		public int x;

		public int y;

		public int gCost;

		public int hCost;

		public NodeItem parent;

		public int fCost => 0;

		public NodeItem(bool isWall, int x, int y)
		{
		}
	}

	public Transform player;

	public Transform destPos;

	private NodeItem[,] grid;

	private int w;

	private int h;

	private GameObject WallRange;

	private GameObject PathRange;

	private List<GameObject> pathObj;

	private NodeItem[] nearNodes;

	public void Init(int[,] list)
	{
	}

	public NodeItem getItem(Vector3 position)
	{
		return null;
	}

	public NodeItem[] getNeibourhood(NodeItem node)
	{
		return null;
	}

	public void ResetNodePathType()
	{
	}

	public void updatePath(List<NodeItem> lines)
	{
	}
}
