using System.IO;

namespace GameProtocol
{
	public sealed class CRespPveSeasonActivity : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CPveActivityExchangeData[] m_vecExchangeData;

		public ushort m_nType;

		public uint m_nExchangePoint;

		public uint m_nDailyPoint;

		public uint m_nDailyMaxPoint;

		public ushort m_nId;

		public short m_nCount;

		public ushort m_ntotalCount;

		public string m_strActivityPointConfig;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
