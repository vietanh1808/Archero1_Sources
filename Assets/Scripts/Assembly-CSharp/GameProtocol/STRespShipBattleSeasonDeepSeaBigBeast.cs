using System.IO;

namespace GameProtocol
{
	public sealed class STRespShipBattleSeasonDeepSeaBigBeast : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nCurActivityStage;

		public ulong m_nBossDamage;

		public ulong m_nBossMaxHP;

		public uint m_nDailyChallengeCount;

		public uint m_nBossDepthRewardBits;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nRankEndTime;

		public STSpecia3DepthRewardData[] m_vecSpecia3DepthRewardData;

		public STSpecia3TreasureRewardData[] m_vecSpecia3TreasureRewardData;

		public STShipBattleSeasonIsLandRankInfo mstRankInfo;

		public uint m_nChallengeLimit;

		public uint m_nCurLuckyValue;

		public uint[] m_vecTreasureRewardID;

		public ulong m_nTreasureStartTime;

		public ulong m_nTreasureEndTime;

		public uint m_nExtraAddDistance;

		public uint m_nCurDebuffStatus;

		public uint m_nTreasureRuinsRewardBits;

		public STSpecia3DepthRewardData[] m_vecSpecia3TreasureDepthRewardData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
