using System.IO;

namespace GameProtocol
{
	public sealed class STActivityDailyPlayStage130Rank
	{
		public STActivityDailyPlayStage130RankItem[] m_vecGroupRank;

		public ulong m_nGroupRankValue;

		public uint m_nGroupRank;

		public STActivityDailyPlayStage130RankItem[] m_vecGlobalRank;

		public ulong m_nGlobalRankValue;

		public uint m_nGlobalRank;

		public bool m_bIsBlacklist;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
