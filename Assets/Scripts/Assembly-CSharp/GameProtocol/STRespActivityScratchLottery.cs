using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityScratchLottery : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public uint m_nItemId;

		public uint[] vecPrice;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public ushort m_nBuyCnt;

		public ushort m_nRound;

		public STActivityLotteryRewardData[] m_vecRewardData;

		public STCommonTaskData[] m_vecTaskData;

		public uint[][] vecBingoIds;

		public uint[][] vecHistoryBingos;

		public uint m_nBingCount;

		public uint[] vecTypeCount;

		public uint[] vecCurrIds;

		public ulong m_nRewardEndTime;

		public STActivityLotteryShop m_stShop;

		public STActivityLotteryGift m_stGift;

		public ushort m_nShowShop;

		public ushort m_nShowGift;

		public STAutoDeleteActivityItem m_stAutoDeleteItem;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
