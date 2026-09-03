namespace TCPPacket
{
	public interface ITcpPacket
	{
		byte[] ToByteArray();

		void Serialize(byte[] array);

		ushort GetMessageId();
	}
}
