namespace TCPPacket.ProtoBuf
{
	public class PvPBattleReadyRequestMessage : ProtobufTcpPacketBase<BattleReadyRequest>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
