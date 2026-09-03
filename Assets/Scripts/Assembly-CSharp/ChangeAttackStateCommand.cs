using TCPPacket;
using UnityEngine;

public class ChangeAttackStateCommand : BaseCommand
{
	public int attackState;

	public Quaternion attackDirect;

	public Quaternion lineDirect;

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override void Clear()
	{
	}

	public void Copy(ChangeAttackStateCommand cmd)
	{
	}

	public override TcpPacketBase ToPacket(int pguid)
	{
		return null;
	}

	public override void InitByTcpPacket(TcpPacketBase packet)
	{
	}
}
