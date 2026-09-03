namespace TCPPacket
{
	public class LearnSkillCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public int skillId;

		public bool isAdd;

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
