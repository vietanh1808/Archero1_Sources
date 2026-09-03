using System.IO;

namespace GameProtocol
{
	public sealed class CHeroSkin
	{
		public string m_nUniqueID;

		public ulong m_nRowID;

		public uint m_nSkinID;

		public uint m_nLevel;

		public ulong m_nExpireTime;

		public bool m_bActive;

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
