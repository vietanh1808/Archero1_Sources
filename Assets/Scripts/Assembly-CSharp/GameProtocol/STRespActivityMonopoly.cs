using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityMonopoly : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nRewardEndTime;

		public ulong m_nEndTime;

		public ushort m_nLayerGameLevel;

		public ushort m_nLayerIndex;

		public ulong m_nRefreshTime;

		public uint m_nTotalScore;

		public STActivityMonopolyCore m_stCore;

		public STActivityMonopolyTask m_stTask;

		public STActivityMonopolyShop m_stShop;

		public STActivityMonopolyGift m_stGift;

		public STActivityMonopolyAchievement m_stAchievement;

		public STActivityMonopolyRank m_stRank;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public ushort m_nGrade;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public Dictionary<uint, STCommonQuickBuyData> m_mapQuickBuyData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
