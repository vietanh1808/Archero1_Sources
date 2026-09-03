namespace TCPPacket.ProtoBuf
{
	public class PvPEnterDoorRequestMessage : ProtobufTcpPacketBase<EnterDoorRequest>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
