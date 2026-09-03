using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonArena : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nNoBattleTime;

		public STShipBattleSeasonArenaRankInfo m_stRankInfo;

		public STShipBattleSeasonArenaTarget[] m_vecTarget;

		public STShipBattleSeasonArenaBattleLog[] m_vecBattleLog;

		public CRewardItem[] m_vecRewardItem;

		public CRewardItem[] m_vecHistoryRewardItem;

		public string[] m_vecRankRewardJsonConf;

		public Dictionary<uint, STCommonQuickBuyTieredData> m_mapQuickBuyData;

		public bool bHasDailyReward;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
