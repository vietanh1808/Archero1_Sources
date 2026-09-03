namespace TCPPacket.ProtoBuf
{
	public class PvPEnterMapRequestMessage : ProtobufTcpPacketBase<EnterMapRequest>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
