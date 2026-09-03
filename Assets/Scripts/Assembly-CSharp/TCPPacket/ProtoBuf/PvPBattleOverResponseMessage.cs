namespace TCPPacket.ProtoBuf
{
	public class PvPBattleOverResponseMessage : ProtobufTcpPacketBase<BattleOverResponse>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
