using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityDiceBattle : IProtocol
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

		public STActivityDiceBattleCore m_stCore;

		public STActivityDiceBattleTask m_stTask;

		public STActivityDiceBattleShop m_stShop;

		public STActivityDiceBattleGift m_stGift;

		public STActivityDiceBattleAchievement m_stAchievement;

		public Dictionary<uint, STCommonQuickBuyData> m_mapQuickBuyData;

		public Dictionary<uint, ushort> m_mapInitItemNum;

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
