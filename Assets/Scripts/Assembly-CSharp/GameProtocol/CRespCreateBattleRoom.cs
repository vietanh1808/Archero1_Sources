using System.IO;

namespace GameProtocol
{
	public sealed class CRespCreateBattleRoom : IProtocol
	{
		public const ushort MsgType = 10000;

		public string m_strRoomToken;

		public string m_strConnectInfo;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
