using System.IO;

namespace GameProtocol
{
	public sealed class CManorVisitorOperationInfo
	{
		public ulong m_nUserID;

		public uint m_nType;

		public uint m_nMsgId;

		public uint m_nTimes;

		public ulong m_nTimestamp;

		public CRewardItem[] m_vecRewardItems;

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
