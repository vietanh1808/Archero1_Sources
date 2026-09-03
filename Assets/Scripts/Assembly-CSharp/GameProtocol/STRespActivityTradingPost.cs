using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityTradingPost : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nOpenVersion;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nRewardEndTime;

		public ulong m_nEndTime;

		public uint m_nTag;

		public ulong m_nDailyTime;

		public uint m_nOpenGameLevel;

		public uint m_nMaxTradeCoin;

		public STActivityTradingPostShop m_stShop;

		public STActivityTradingPostAchievement m_stAchievement;

		public uint m_nCurTimeNode;

		public uint m_nCurDay;

		public uint m_nBuyCount;

		public uint m_nSellCount;

		public STActivityTradingPostGoods[] m_vecGoods;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STCommonQuickBuyData m_stQuickBuy;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public uint[] m_vecTradeTime;

		public uint m_nShopCoinId;

		public uint m_nTradingCoinId;

		public uint m_nGroupRankNum;

		public uint m_nRefreshInterval;

		public uint m_nMaxBuyCount;

		public uint m_nMaxSellCount;

		public uint[] m_vecDailyX;

		public uint[] m_vecHistoryX;

		public STActivityTradingPostRankRewardData[] m_vecRankRewardData;

		public STActivityTradingPostRankInfo m_stRankInfo;

		public STActivityTradingPostRecord[] m_stPostRecord;

		public STActivityTradingPostRewardPreview[] m_vecPostRewardPreview;

		public uint m_nQuickItemBuyOne;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
