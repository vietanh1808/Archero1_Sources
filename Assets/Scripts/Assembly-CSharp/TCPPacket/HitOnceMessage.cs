namespace TCPPacket
{
	public class HitOnceMessage : BytesTcpPacketBase
	{
		public int guid;

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
