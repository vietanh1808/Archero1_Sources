using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityWorldCup : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nType;

		public ulong m_nShowTime;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nRewardTimestamp;

		public uint m_nStyleId;

		public string m_nStrChampionSchedule;

		public string m_nStrDailyTask;

		public string m_nStrTaskAchieve;

		public string m_nStrBets;

		public string m_nStrChampionBet;

		public string m_nStrChampionTeam;

		public CWorldCupExchangeData[] m_vecExchangeData;

		public uint m_nId;

		public short m_nCount;

		public ushort m_nTotalCount;

		public Dictionary<uint, STCommonQuickBuyData> m_mapQuickBuyData;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public uint m_nOpenGameLevel;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
