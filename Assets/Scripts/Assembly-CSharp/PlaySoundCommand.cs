using TCPPacket;
using UnityEngine;

public class PlaySoundCommand : BaseCommand
{
	public int soundId;

	public short soundType;

	public Vector3 soundPos;

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
