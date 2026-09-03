namespace TCPPacket.ProtoBuf
{
	public class PvPUserUpdateHpRequestMessage : ProtobufTcpPacketBase<UserUpdateHpRequest>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
