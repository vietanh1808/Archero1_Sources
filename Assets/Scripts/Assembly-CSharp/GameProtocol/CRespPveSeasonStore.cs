using System.IO;

namespace GameProtocol
{
	public sealed class CRespPveSeasonStore : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CPveExchangeData[] m_vecExchangeData;

		public CPveExchangeData[] m_vecScoreExchangeData;

		public ushort m_nType;

		public ushort m_nId;

		public short m_nCount;

		public ushort m_ntotalCount;

		public string[] m_arrayConf;

		public uint[] m_arrayPurchased;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
