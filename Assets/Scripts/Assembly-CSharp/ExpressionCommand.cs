using TCPPacket;

public class ExpressionCommand : BaseCommand
{
	public int expressionId;

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
