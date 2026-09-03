namespace TCPPacket
{
	public class RebornCommandMessage : BytesTcpPacketBase
	{
		public int Guid;

		public int hpPart;

		public bool skillReborn;

		public bool noLogic;

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
