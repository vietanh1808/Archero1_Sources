using System.IO;

namespace GameProtocol
{
	public sealed class CRewardItem
	{
		public uint m_nRewardType;

		public uint m_nItemType;

		public uint m_nItemCount;

		public uint m_nExpireTime;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
