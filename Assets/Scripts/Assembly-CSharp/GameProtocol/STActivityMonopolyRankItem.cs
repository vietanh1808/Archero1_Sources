using System.IO;

namespace GameProtocol
{
	public sealed class STActivityMonopolyRankItem : STBaseRank
	{
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
