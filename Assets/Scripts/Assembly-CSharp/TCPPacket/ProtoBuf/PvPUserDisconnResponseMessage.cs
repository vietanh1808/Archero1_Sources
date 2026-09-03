namespace TCPPacket.ProtoBuf
{
	public class PvPUserDisconnResponseMessage : ProtobufTcpPacketBase<UserDisconnResponse>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
