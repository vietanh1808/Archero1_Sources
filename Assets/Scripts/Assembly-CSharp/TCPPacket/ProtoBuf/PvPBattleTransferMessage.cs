namespace TCPPacket.ProtoBuf
{
	public class PvPBattleTransferMessage : ProtobufTcpPacketBase<BattleTransfer>
	{
		public override ushort GetMessageId()
		{
			return 0;
		}
	}
}
