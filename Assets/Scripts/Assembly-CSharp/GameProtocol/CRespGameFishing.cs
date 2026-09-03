using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameFishing : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nOpenTime;

		public ulong m_nFishEndTime;

		public ulong m_nRewardEndTime;

		public ulong m_nEndTime;

		public ushort m_nLayerIndex;

		public uint[] m_vecFishingRodId;

		public uint m_nMaxUnlockAreaId;

		public uint[] m_vecFishCatalog;

		public uint m_nCatalogReceivedBit;

		public STGameFishingRank m_stGameFishingRank;

		public STFishInfo[] m_vecFishInfo;

		public uint m_nFishId;

		public uint m_nTotalWeight;

		public CFishingExchangeData[] m_vecExchangeData1;

		public CFishingExchangeData[] m_vecExchangeData2;

		public uint m_nBuyBaitTimes;

		public Dictionary<uint, uint> m_mapGiftBuyTimes;

		public string m_strTasks;

		public string m_vecGiftConfig;

		public string m_vecTaskConfig;

		public uint m_nInitItemNum;

		public uint m_nTotalFishing;

		public ushort m_nGrade;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
