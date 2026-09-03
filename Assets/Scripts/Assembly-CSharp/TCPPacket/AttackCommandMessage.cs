namespace TCPPacket
{
	public class AttackCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public int targetGuid;

		public int angle;

		public int attackId;

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
