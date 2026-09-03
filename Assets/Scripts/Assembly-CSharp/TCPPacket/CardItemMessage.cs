namespace TCPPacket
{
	public class CardItemMessage : BytesTcpPacketBase
	{
		public int CardId;

		public int Count;

		public int Level;

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
