using System.IO;

namespace GameProtocol
{
	public sealed class STActivitySummonArchersRank
	{
		public STActivitySummonArchersRankItem[] m_vecRank;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
