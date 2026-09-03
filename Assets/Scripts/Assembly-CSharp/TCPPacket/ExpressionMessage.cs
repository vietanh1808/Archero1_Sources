namespace TCPPacket
{
	public class ExpressionMessage : BytesTcpPacketBase
	{
		public int Guid;

		public int expressionId;

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
