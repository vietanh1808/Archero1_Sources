namespace TCPPacket.ProtoBuf
{
	public class PvPUserHeartbeatRequestMessage : ProtobufTcpPacketBase<UserHeartbeatRequest>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
