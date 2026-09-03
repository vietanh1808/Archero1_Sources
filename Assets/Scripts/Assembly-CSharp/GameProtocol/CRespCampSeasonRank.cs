using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampSeasonRank : IProtocol
	{
		public short m_nStatusCode;

		public ushort m_nType;

		public CCampRank[] m_arrayBlockRank;

		public CCampRank[] m_arrayTalentRank;

		public CCampRank[] m_arrayBossRank;

		public CCampRank[] m_arrayHomeRank;

		public ulong m_nBlockValue;

		public uint m_nBlockRank;

		public ulong m_nTalentValue;

		public uint m_nTalentRank;

		public ulong m_nBossValue;

		public uint m_nBossRank;

		public ulong m_nHomeValue;

		public uint m_nHomeRank;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
