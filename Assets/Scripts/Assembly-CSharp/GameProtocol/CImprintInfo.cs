using System.IO;

namespace GameProtocol
{
	public sealed class CImprintInfo
	{
		public ulong m_nRowID;

		public uint m_nID;

		public ushort m_nLevel;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
