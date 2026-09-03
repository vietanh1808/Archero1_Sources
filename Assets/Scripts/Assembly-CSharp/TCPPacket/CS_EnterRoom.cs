namespace TCPPacket
{
	public class CS_EnterRoom : BytesTcpPacketBase
	{
		public string roomToken;

		public ushort isMain;

		public ulong playerToken;

		public ulong otherPlayerToken;

		public string roomId;

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
