using TCPPacket;

public class CustomJsonDataCommand : BaseCommand
{
	public string jsonData;

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
