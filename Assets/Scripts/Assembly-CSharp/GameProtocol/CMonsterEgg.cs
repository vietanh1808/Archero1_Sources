using System.IO;

namespace GameProtocol
{
	public sealed class CMonsterEgg
	{
		public uint m_nEquipID;

		public uint m_nStep;

		public ushort m_nStatus;

		public ulong m_nRowID;

		public ulong m_nTimestamp;

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
