namespace TCPPacket
{
	public class ApplicationPauseMessage : BytesTcpPacketBase
	{
		public bool isPause;

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
