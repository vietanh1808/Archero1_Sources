namespace TCPPacket
{
	public class RoomDataMessage : BytesTcpPacketBase
	{
		public int roomId;

		public string tmx;

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
