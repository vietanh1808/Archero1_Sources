using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityArtifactTrial : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nRankEndTime;

		public uint m_nProgress;

		public uint m_nCurDifficulty;

		public uint m_nMaxDifficulty;

		public uint m_nDailyChallengeCount;

		public uint m_nProgressRewardBits;

		public Dictionary<uint, uint> m_mapDifficultyCount;

		public STActivityArtifactProgressRewardData[] m_vecProgressRewardData;

		public STActivityArtifactRankRewardData[] m_vecRankRewardData;

		public STActivityArtifactTrialRankInfo mstRankInfo;

		public uint m_nChallengeLimit;

		public STArtifactTrialTalent[] m_vecTalent;

		public STActivityArtifactPointRewardData[] m_vecPointRewardData;

		public uint[] m_vecFreeArtifact;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
