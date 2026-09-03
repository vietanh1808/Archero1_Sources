using System.IO;

namespace GameProtocol
{
	public sealed class CMonsterItem
	{
		public string m_nUniqueID;

		public ulong m_nRowID;

		public uint m_nMonID;

		public uint m_nLevel;

		public uint m_nKill;

		public ushort m_nStar;

		public uint m_nExtraCount;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
