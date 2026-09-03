namespace TCPPacket.ProtoBuf
{
	public class PvPUserDieRequestMessage : ProtobufTcpPacketBase<UserDieRequest>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
