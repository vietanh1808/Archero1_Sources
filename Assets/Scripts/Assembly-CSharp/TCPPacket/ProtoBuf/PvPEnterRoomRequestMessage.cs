namespace TCPPacket.ProtoBuf
{
	public class PvPEnterRoomRequestMessage : ProtobufTcpPacketBase<EnterRoomRequest>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
