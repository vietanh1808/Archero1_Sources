using System.IO;

namespace GameProtocol
{
	public sealed class CArtifact
	{
		public ulong m_nRowID;

		public uint m_nArtifactID;

		public uint m_nStarID;

		public uint m_nLevel;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
