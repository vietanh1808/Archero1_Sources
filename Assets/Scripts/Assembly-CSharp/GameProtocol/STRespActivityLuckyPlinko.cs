using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityLuckyPlinko : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public uint m_nOpenGameLevel;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nGameEndTime;

		public uint m_nRound;

		public ushort m_nBigAwardGridId;

		public uint m_nTotalCount;

		public ulong m_nRefreshTime;

		public STActivityLuckyPlinkoGrid m_stGrid;

		public ushort[] m_vecHitGridId;

		public uint[] m_vecPathId;

		public STLuckyPlinkoNailData[] m_vecNailData;

		public STLuckyPlinkoHitInfo[] m_vecHitInfo;

		public uint m_nPreRound;

		public STActivityLuckyPlinkoGrid m_stGridPreRound;

		public STActivityLuckyPlinkoShop m_stShop;

		public STActivityLuckyPlinkoGift m_stGift;

		public STActivityLuckyPlinkoTask m_stTask;

		public STActivityLuckyPlinkoAchievement m_stAchievement;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public uint m_nBallItemId;

		public STLuckyPlinkoQuickBuyData m_stQuickBuy;

		public STActivityLuckyPlinkoReward m_stBigReward;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
