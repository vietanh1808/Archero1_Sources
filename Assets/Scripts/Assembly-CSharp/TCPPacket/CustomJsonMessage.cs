namespace TCPPacket
{
	public class CustomJsonMessage : BytesTcpPacketBase
	{
		public int Guid;

		public string jsonData;

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
