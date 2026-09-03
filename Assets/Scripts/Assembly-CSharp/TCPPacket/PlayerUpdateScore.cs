namespace TCPPacket
{
	public class PlayerUpdateScore : BytesTcpPacketBase
	{
		public int guid;

		public int score;

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
