namespace TCPPacket
{
	public class SetTargetCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public int targetGuid;

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
