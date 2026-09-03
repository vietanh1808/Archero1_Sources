namespace TCPPacket
{
	public class BehaviorCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public int behaviorId;

		public int behaviorType;

		public string behaviorParam;

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
