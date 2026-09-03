namespace TCPPacket
{
	public class ChangeHpCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public int sourceGuid;

		public long hpChange;

		public long curHp;

		public long maxHp;

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
