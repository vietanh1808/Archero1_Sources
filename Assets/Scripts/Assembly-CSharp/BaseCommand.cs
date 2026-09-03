using TCPPacket;

public abstract class BaseCommand
{
	public int guid;

	public bool isSync;

	public new abstract CommandType GetType();

	public abstract TcpPacketBase ToPacket(int guid);

	public abstract void InitByTcpPacket(TcpPacketBase packet);

	public virtual void Clear()
	{
	}
}
