namespace TCPPacket
{
	public class GoodData : BytesTcpPacketBase
	{
		public string goodName;

		public bool isPercent;

		public long value;

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
