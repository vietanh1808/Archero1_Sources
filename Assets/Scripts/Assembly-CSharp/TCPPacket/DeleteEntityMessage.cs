namespace TCPPacket
{
	public class DeleteEntityMessage : BytesTcpPacketBase
	{
		public int Guid;

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
