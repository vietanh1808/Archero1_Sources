namespace TCPPacket
{
	public class ChangeAttackStateMessage : BytesTcpPacketBase
	{
		public int guid;

		public int attackState;

		public Vector4Message attackDirect;

		public Vector4Message lineDirect;

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
