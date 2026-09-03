using System.IO;

namespace GameProtocol
{
	public sealed class CRespPveSeasonRank : IProtocol
	{
		public short m_nStatusCode;

		public ushort m_nType;

		public uint m_nScore;

		public uint m_nRank;

		public CPveStageRank[] m_arrayRank;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
