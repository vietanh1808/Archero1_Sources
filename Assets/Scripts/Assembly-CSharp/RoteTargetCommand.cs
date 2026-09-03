using TCPPacket;

public class RoteTargetCommand : BaseCommand
{
	public EntityBase target;

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override void Clear()
	{
	}

	public override TcpPacketBase ToPacket(int guid)
	{
		return null;
	}

	public override void InitByTcpPacket(TcpPacketBase packet)
	{
	}
}
