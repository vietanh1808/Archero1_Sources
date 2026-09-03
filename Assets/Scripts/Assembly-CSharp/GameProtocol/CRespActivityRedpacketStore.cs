using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityRedpacketStore : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CRedpacketExchangeData[] m_vecExchangeData;

		public ushort m_nType;

		public ushort m_nId;

		public short m_nCount;

		public ushort m_ntotalCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
