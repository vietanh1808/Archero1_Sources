namespace TCPPacket
{
	public class ActionCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public string action;

		public string replaceAction;

		public int actionSpeedOffset;

		public bool isDoAction;

		public bool isForcePlay;

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
