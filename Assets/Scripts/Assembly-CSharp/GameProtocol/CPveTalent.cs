using System.IO;

namespace GameProtocol
{
	public sealed class CPveTalent
	{
		public uint m_nID;

		public uint m_nLevel;

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
