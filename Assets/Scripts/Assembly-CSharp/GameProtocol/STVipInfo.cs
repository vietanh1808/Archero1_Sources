using System.IO;

namespace GameProtocol
{
	public sealed class STVipInfo
	{
		public bool m_nChange;

		public ushort m_nVipLevel;

		public uint m_nVipScore;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
