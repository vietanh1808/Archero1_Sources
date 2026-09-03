namespace TCPPacket.ProtoBuf
{
	public class PvPUserHeartbeatResponseMessage : ProtobufTcpPacketBase<UserHeartbeatResponse>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
