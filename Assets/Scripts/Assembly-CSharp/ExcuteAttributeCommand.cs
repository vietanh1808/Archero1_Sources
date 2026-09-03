using TCPPacket;

public class ExcuteAttributeCommand : BaseCommand
{
	public string attName;

	public long attValue;

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
