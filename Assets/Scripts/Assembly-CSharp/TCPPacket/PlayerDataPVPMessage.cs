using TCPPacket.ProtoBuf;

namespace TCPPacket
{
	public class PlayerDataPVPMessage : TcpPacketBase
	{
		public PlayerInfo playerInfoData;

		public override ushort GetMessageId()
		{
			return 0;
		}

		public override byte[] ToByteArray()
		{
			return null;
		}

		public override void Serialize(byte[] array)
		{
		}
	}
}
