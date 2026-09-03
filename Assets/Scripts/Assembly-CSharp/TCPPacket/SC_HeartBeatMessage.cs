namespace TCPPacket
{
	public class SC_HeartBeatMessage : BytesTcpPacketBase
	{
		public long clientTime;

		public long serverTime;

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
