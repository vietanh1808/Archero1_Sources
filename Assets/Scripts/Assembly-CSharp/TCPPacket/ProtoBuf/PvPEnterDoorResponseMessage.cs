namespace TCPPacket.ProtoBuf
{
	public class PvPEnterDoorResponseMessage : ProtobufTcpPacketBase<EnterDoorResponse>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
