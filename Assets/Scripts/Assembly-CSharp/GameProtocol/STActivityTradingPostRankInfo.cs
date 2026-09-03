using System.IO;

namespace GameProtocol
{
	public sealed class STActivityTradingPostRankInfo
	{
		public STActivityTradingPostRankItem[] m_vecRank;

		public long m_nRankValue;

		public uint m_nRank;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
