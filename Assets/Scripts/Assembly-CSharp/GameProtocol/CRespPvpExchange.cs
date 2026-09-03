using System.IO;

namespace GameProtocol
{
	public sealed class CRespPvpExchange : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ulong m_nEndTime;

		public string m_strDropItems;

		public CPvpExchangeData[] m_vecExchangeData;

		public ushort m_nIndex;

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
