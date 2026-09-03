using System.IO;

namespace GameProtocol
{
	public sealed class STActivityMonopolyRank
	{
		public STActivityMonopolyRankItem[] m_vecGroupRank;

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
