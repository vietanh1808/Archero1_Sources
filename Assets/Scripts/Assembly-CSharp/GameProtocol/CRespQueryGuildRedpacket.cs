using System.IO;

namespace GameProtocol
{
	public sealed class CRespQueryGuildRedpacket : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CGuildRedpacketData[] m_arrayRedpacketData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
