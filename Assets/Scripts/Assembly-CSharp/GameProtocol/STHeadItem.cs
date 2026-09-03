using System.IO;

namespace GameProtocol
{
	public sealed class STHeadItem
	{
		public uint m_nHeadId;

		public ushort m_nType;

		public ulong m_nTimestamp;

		public bool m_bActive;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
