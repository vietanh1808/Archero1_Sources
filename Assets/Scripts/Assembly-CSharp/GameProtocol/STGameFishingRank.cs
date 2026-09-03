using System.IO;

namespace GameProtocol
{
	public sealed class STGameFishingRank
	{
		public STGameFishingRankItem[][] m_vecTotalRank;

		public ulong m_nTotalRankValue;

		public uint m_nTotalRank;

		public uint m_nTotalRankPartIndex;

		public STGameFishingRankItem[] m_vecGroupRank;

		public ulong m_nGroupRankValue;

		public uint m_nGroupRank;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
