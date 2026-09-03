namespace TCPPacket
{
	public class ExcuteAttrMessage : BytesTcpPacketBase
	{
		public int Guid;

		public string attName;

		public long attValue;

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
