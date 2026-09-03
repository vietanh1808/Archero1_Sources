using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityPirateTreasureExchange : IProtocol
	{
		public ushort[][] m_nExchangeFreshTimeCfg;

		public ushort m_nExchangeRefreshCntCfg;

		public ushort m_nExchangeNormalIndex;

		public uint m_nExchangeNormalBuyTimes;

		public STActivityPirateTreasureExchangeData[] m_vecExchangeNormalData;

		public string m_strExchangeNormalCfg;

		public STActivityPirateTreasureExchangeData[] m_vecExchangeSuperData;

		public string m_strExchangeSuperCfg;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
