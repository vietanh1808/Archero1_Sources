namespace TCPPacket
{
	public abstract class TcpPacketBase : ITcpPacket
	{
		public abstract byte[] ToByteArray();

		public abstract void Serialize(byte[] array);

		public abstract ushort GetMessageId();
	}
}
