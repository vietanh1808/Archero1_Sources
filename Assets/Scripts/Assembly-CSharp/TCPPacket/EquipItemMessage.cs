namespace TCPPacket
{
	public class EquipItemMessage : BytesTcpPacketBase
	{
		public ulong m_nRowID;

		public int m_nEquipID;

		public int m_nLevel;

		public int m_nFragment;

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
