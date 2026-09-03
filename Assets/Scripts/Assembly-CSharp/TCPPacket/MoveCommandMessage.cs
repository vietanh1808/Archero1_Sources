namespace TCPPacket
{
	public class MoveCommandMessage : BytesTcpPacketBase
	{
		public int guid;

		public long startTime;

		public int pathCount;

		public Vector3Message[] directArray;

		public Vector3Message startPos;

		public int moveSpeed;

		public bool isRoteMoveDirect;

		public string action;

		public Vector4Message attackDirect;

		public Vector4Message lineDirect;

		public bool needMove;

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
