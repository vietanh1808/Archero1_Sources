namespace TCPPacket
{
	public class EnterGameMessage : BytesTcpPacketBase
	{
		public int ChapterId;

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
