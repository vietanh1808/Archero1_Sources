using System.IO;

namespace GameProtocol
{
	public sealed class CRespDailyPlayExchange : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ulong m_nEndTime;

		public string m_strDropItems;

		public CDailyPlayExchangeData[] m_vecExchangeData;

		public ushort m_nIndex;

		public short m_nCount;

		public ushort m_ntotalCount;

		public uint m_nHeroId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
