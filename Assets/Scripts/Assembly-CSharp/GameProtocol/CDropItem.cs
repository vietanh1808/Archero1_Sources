using System.IO;

namespace GameProtocol
{
	public sealed class CDropItem
	{
		public uint m_nType;

		public uint m_nItemId;

		public uint m_nItemCount;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
