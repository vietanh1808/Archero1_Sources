using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CWing
	{
		public ulong m_nRowID;

		public uint m_nWingID;

		public uint m_nLevel;

		public uint m_nStarID;

		public Dictionary<ushort, ulong> m_mapAttach;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
