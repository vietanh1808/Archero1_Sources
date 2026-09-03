using System.IO;

namespace GameProtocol
{
	public sealed class CManorWorker
	{
		public ulong m_nERowID;

		public uint m_nId;

		public ulong m_nStar;

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
