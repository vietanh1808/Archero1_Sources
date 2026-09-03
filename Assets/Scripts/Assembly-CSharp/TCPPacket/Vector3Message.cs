namespace TCPPacket
{
	public class Vector3Message : BytesTcpPacketBase
	{
		public int x;

		public int y;

		public int z;

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
