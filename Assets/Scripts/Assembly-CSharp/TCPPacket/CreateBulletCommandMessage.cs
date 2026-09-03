namespace TCPPacket
{
	public class CreateBulletCommandMessage : BytesTcpPacketBase
	{
		public int sourceId;

		public int targetId;

		public int bulletId;

		public Vector3Message bulletPos;

		public int rote;

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
