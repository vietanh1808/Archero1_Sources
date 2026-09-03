using TCPPacket;

public class ChangeHpCommand : BaseCommand
{
	public EntityBase source;

	public long hpChange;

	public long curHp;

	public long maxHp;

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
