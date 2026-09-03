namespace TCPPacket
{
	public class BeginLoadMapMessage : BytesTcpPacketBase
	{
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
