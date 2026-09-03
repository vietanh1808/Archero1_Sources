using TCPPacket;

public class RebornCommand : BaseCommand
{
	public int hpPart;

	public bool skillReborn;

	public bool noLogic;

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

	public override void Clear()
	{
	}
}
