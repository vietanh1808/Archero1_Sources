using TCPPacket;

public class AttackCommand : BaseCommand
{
	public EntityBase target;

	public float angle;

	public int attackId;

	public bool isPlayAction;

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
