using TCPPacket;

public class ActionCommand : BaseCommand
{
	public string action;

	public string replaceAction;

	public float actionSpeedOffset;

	public bool isDoAction;

	public bool isForcePlay;

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
