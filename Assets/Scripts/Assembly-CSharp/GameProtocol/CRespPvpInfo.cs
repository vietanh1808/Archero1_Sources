using System.IO;

namespace GameProtocol
{
	public sealed class CRespPvpInfo : IProtocol
	{
		public short m_nStatusCode;

		public ushort m_nTag;

		public ushort m_nDivision;

		public uint m_nScore;

		public uint m_nCount;

		public uint m_nWinCount;

		public uint m_nWinMaxCount;

		public uint m_nBestRank;

		public uint m_nMaxWin;

		public ushort m_nJoinTagCount;

		public ushort m_nSubDivision;

		public CPvpRank[] m_arrayRank;

		public bool m_bWorshipEnable;

		public CPvpBattleLog[] m_arrayBattleLog;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
