using System.IO;

namespace GameProtocol
{
	public sealed class STActivityArtifactTrialRankInfo
	{
		public STActivityArtifactTrialRankItem[] m_vecRank;

		public ulong m_nRankValue;

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
