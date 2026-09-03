namespace TCPPacket
{
	public class RoteCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public int angle;

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
