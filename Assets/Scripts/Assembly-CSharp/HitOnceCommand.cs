using TCPPacket;

public class HitOnceCommand : BaseCommand
{
	public HitStruct hitStruct;

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override void Clear()
	{
	}

	public void Copy(HitOnceCommand cmd)
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
