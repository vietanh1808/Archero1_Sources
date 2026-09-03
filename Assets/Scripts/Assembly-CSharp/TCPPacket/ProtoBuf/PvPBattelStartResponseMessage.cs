namespace TCPPacket.ProtoBuf
{
	public class PvPBattelStartResponseMessage : ProtobufTcpPacketBase<BattelStartResponse>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
