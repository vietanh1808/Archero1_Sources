namespace TCPPacket
{
	public class StopMoveCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public Vector3Message stopPos;

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
