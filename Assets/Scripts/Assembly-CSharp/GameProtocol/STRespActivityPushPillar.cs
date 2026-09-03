using System;
using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespActivityPushPillar : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nRewardEndTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public uint m_nRoundPushCount;

		public uint m_nTotalCostCoin;

		public uint m_nTotalRefreshCount;

		public ushort m_nRoundPushed;

		public uint m_nDailyBuyCoinCount;

		public STActivityPushPillarCellProtoData[][] m_vecBoardColumns;

		public ushort[] m_vecColumnPushedRows;

		public uint[] m_vecChoiceRewardIds;

		public STActivityPushPillarUpgradeEvent[] m_vecUpgradeEvents;

		public ulong[] m_vecProgressRewardBits;

		public STActivityPushPillarShop m_stShop;

		public STActivityPushPillarGift m_stGift;

		public STActivityPushPillarTask m_stTask;

		public STCommonQuickBuyData m_stQuickBuy;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public ulong m_nDailyTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
