using System.IO;

namespace GameProtocol
{
	public sealed class CColorfulWeaponSkin
	{
		public string m_nUniqueID;

		public ulong m_nRowID;

		public uint m_nSkinID;

		public bool m_bActive;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
