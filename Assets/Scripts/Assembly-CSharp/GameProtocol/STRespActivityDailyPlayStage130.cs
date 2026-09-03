using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityDailyPlayStage130 : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nGroupId;

		public ulong[] m_vecStageDamage;

		public STActivityDailyPlayStage130Rank m_stRank;

		public ulong m_nRankEndTime;

		public ulong m_nRankRewardTime;

		public STActivityDailyPlayStage130PeakRankRewardData[] m_vecPeakRankRewardData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
