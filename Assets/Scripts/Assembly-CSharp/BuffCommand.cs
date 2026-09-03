using TCPPacket;

public class BuffCommand : BaseCommand
{
	public short AddOrRemove;

	public int buffId;

	public EntityBase source;

	public float[] args;

	public int argCount;

	public override void Clear()
	{
	}

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override TcpPacketBase ToPacket(int guid)
	{
		return null;
	}

	public override void InitByTcpPacket(TcpPacketBase packet)
	{
	}
}
