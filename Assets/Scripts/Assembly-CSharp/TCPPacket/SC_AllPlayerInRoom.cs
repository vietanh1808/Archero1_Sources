namespace TCPPacket
{
	public class SC_AllPlayerInRoom : BytesTcpPacketBase
	{
		public ushort result;

		public override ushort GetMessageId()
		{
			return 0;
		}

		public override void Read()
		{
		}

		public override void Write()
		{
		}
	}
}
