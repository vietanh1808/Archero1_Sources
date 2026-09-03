using System.IO;

namespace GameProtocol
{
	public sealed class STActivityHuntingRank
	{
		public STActivityHuntingRankItem[][] m_vecTotalRank;

		public ulong m_nTotalRankValue;

		public uint m_nTotalRank;

		public uint m_nTotalRankPartIndex;

		public STActivityHuntingRankItem[] m_vecGroupRank;

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
