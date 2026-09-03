using System.IO;

namespace GameProtocol
{
	public sealed class CGuildAchInfo
	{
		public uint m_nGuildDonateCnt;

		public uint m_nGuildTaskCnt;

		public uint m_nGuildShareCnt;

		public uint m_nGuildSignCnt;

		public uint m_nGuildHelpCnt;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
