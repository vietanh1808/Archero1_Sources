using System.IO;

namespace GameProtocol
{
	public sealed class STActivityTradingPostRankItem : STBaseRank
	{
		public new long m_nValue;

		public uint[] m_vecUsingMedals;

		public new void ReadFromStream(BinaryReader reader)
		{
		}

		public new void WriteToStream(BinaryWriter writter)
		{
		}

		public new byte[] buildPacket()
		{
			return null;
		}
	}
}
