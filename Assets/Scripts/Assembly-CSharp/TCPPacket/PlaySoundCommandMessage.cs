namespace TCPPacket
{
	public class PlaySoundCommandMessage : BytesTcpPacketBase
	{
		public int soundId;

		public short soundType;

		public Vector3Message soundPos;

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
