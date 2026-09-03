namespace TCPPacket.ProtoBuf
{
	public class PvPEnterRoomResponseMessage : ProtobufTcpPacketBase<EnterRoomResponse>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
