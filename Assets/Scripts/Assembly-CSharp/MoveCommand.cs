using System.Collections.Generic;
using TCPPacket;
using UnityEngine;

public class MoveCommand : BaseCommand
{
	public long startTime;

	public int pathCount;

	public Vector3[] directArray;

	public Vector3 startPos;

	public float moveSpeed;

	public bool isRoteMoveDirect;

	public string action;

	public bool isMoveY;

	public float startY;

	public Quaternion attackDirect;

	public Quaternion lineDirect;

	public bool needMove;

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override void Clear()
	{
	}

	public void Copy(MoveCommand cmd)
	{
	}

	public override TcpPacketBase ToPacket(int guid)
	{
		return null;
	}

	public override void InitByTcpPacket(TcpPacketBase packet)
	{
	}

	public void AddDirect(Vector3 direct, bool isCombinePath = true)
	{
	}

	public void AddPathInfo(List<Grid.NodeItem> findpath, Vector3 startPos)
	{
	}
}
