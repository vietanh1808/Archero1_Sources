using System.IO;

namespace GameProtocol
{
	public sealed class CWeaponSkin
	{
		public string m_nUniqueID;

		public ulong m_nRowID;

		public uint m_nSkinID;

		public bool m_bActive;

		public ushort m_nLevel;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
