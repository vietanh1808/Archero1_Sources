namespace TCPPacket
{
	public class BuffCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public short AddOrRemove;

		public int buffId;

		public int sourceGuid;

		public int[] args;

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
