using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityHunting : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ushort m_nLayerGameLevel;

		public ushort m_nLayerIndex;

		public ulong m_nRefreshTime;

		public uint m_nTotalScore;

		public STActivityHuntingCore m_stCore;

		public STActivityHuntingRecord m_stRecord;

		public STActivityHuntingTask m_stTask;

		public STActivityHuntingShop m_stShop;

		public STActivityHuntingGift m_stGift;

		public STActivityHuntingTalent m_stTalent;

		public Dictionary<uint, STCommonQuickBuyData> m_mapQuickBuyData;

		public STActivityHuntingRank m_stRank;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public ushort m_nGrade;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nRewardEndTime;

		public ulong m_nEndTime;

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
