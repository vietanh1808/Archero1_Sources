using System.IO;

namespace GameProtocol
{
	public sealed class STImprintInfos
	{
		public bool m_nChange;

		public CImprintInfo[] m_vecImprintData;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
