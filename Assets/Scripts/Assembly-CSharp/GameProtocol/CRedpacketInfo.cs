using System.IO;

namespace GameProtocol
{
	public sealed class CRedpacketInfo
	{
		public ulong m_nRowId;

		public ulong m_nUserID;

		public uint m_nRedpacketId;

		public ulong m_nTimestamp;

		public ushort m_nOpenCnt;

		public bool m_nSelfOpened;

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
