using TCPPacket;
using UnityEngine;

public class CreateBulletCommand : BaseCommand
{
	public int bulletId;

	public Vector3 bulletPos;

	public EntityBase source;

	public EntityBase target;

	public int rote;

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override void Clear()
	{
	}

	public override void InitByTcpPacket(TcpPacketBase packet)
	{
	}

	public override TcpPacketBase ToPacket(int guid)
	{
		return null;
	}
}
