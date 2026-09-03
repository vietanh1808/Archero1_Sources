using System.IO;

namespace GameProtocol
{
	public sealed class CRespPveSeasonInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nPveSoulPoint;

		public uint m_nPveSoulCrystal;

		public ushort m_nMaxStage;

		public ushort m_nPveLife;

		public ushort m_nTag;

		public uint m_nSeasonTopic;

		public uint m_nWeekTopic;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint[] m_vecHeroIds;

		public CPveStageRank[] m_arrayRank;

		public ushort m_nBuyLifeCnt;

		public ushort m_nPveMaxLife;

		public ushort m_nDivision;

		public ulong m_nShopEndTimestamp;

		public ulong m_nPveBanTimestamp;

		public uint m_nPveScore;

		public ushort m_nJoinTagCount;

		public ushort m_nJobRefreshCount;

		public ushort[] m_vecJobIds;

		public ushort m_nSubDivision;

		public uint m_nPveSuperSoul;

		public uint m_nPveScoreNew;

		public ushort m_nHardMaxStage;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
