using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespShipBattleSeasonMonsterIsland : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nExploreDepth;

		public uint m_nCurDifficulty;

		public uint m_nMaxDifficulty;

		public uint m_nDailyChallengeCount;

		public uint m_nDepthRewardBits;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nRankEndTime;

		public Dictionary<uint, uint> m_mapDifficultyCount;

		public STSpecialDepthRewardData[] m_vecSpecialDepthRewardData;

		public STShipBattleSeasonIsLandRankInfo mstRankInfo;

		public uint m_nChallengeLimit;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
