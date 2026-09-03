namespace TCPPacket
{
	public class CS_HeartBeatMessage : BytesTcpPacketBase
	{
		public long clientTime;

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
