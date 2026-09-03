using TCPPacket;

public class BehaviorCommand : BaseCommand
{
	public int behaviorId;

	public int behaviorType;

	public string param;

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
