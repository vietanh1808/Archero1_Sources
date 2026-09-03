using TCPPacket;
using UnityEngine;

public class TeleportCommand : BaseCommand
{
	public Vector3 targetPos;

	public override void Clear()
	{
	}

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override void InitByTcpPacket(TcpPacketBase packet)
	{
	}

	public override TcpPacketBase ToPacket(int guid)
	{
		return null;
	}
}
