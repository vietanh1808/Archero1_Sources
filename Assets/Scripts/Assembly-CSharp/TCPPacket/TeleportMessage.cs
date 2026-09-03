namespace TCPPacket
{
	public class TeleportMessage : BytesTcpPacketBase
	{
		public int Guid;

		public Vector3Message targetPos;

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
