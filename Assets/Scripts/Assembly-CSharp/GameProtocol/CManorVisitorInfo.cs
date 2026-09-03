using System.IO;

namespace GameProtocol
{
	public sealed class CManorVisitorInfo
	{
		public ulong m_nUserID;

		public uint m_nHeroId;

		public uint m_nSkinId;

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
