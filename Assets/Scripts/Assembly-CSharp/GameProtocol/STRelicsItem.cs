using System.IO;

namespace GameProtocol
{
	public sealed class STRelicsItem
	{
		public ulong m_nRowId;

		public uint m_nId;

		public ushort m_nLevel;

		public ushort m_nStar;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
