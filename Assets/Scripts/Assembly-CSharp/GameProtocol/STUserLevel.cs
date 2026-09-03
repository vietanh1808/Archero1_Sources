using System.IO;

namespace GameProtocol
{
	public sealed class STUserLevel
	{
		public bool m_nChange;

		public ushort m_nLevel;

		public uint m_nExperince;

		public ulong m_nExperinceInt64;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
