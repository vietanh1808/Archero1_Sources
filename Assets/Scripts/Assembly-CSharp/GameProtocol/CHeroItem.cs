using System.IO;

namespace GameProtocol
{
	public sealed class CHeroItem
	{
		public uint m_nHeroId;

		public uint m_nStar;

		public ushort m_nCoopLevel;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
