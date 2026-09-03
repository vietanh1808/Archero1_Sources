using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonStore : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CShipBattleExchangeData[] m_vecExchangeData;

		public CShipBattleExchangeData[] m_vecScoreExchangeData;

		public ushort m_nType;

		public ushort m_nId;

		public short m_nCount;

		public ushort m_ntotalCount;

		public uint m_nStoreCoinA;

		public uint m_nStoreCoinB;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
