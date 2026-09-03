using System.IO;

namespace GameProtocol
{
	public sealed class STFarmPvpRespInfo : IProtocol
	{
		public short m_nStatusCode;

		public ushort m_nTag;

		public ushort m_nDivision;

		public ushort m_nSubDivision;

		public uint m_nScore;

		public uint m_nCount;

		public uint m_nWinCount;

		public uint m_nRank;

		public uint m_nBestRank;

		public ushort m_nJoinTagCount;

		public ushort m_nDailyCnt;

		public ushort m_nDailyBuyCnt;

		public ushort m_nVictoryRewardIdx;

		public uint m_nPvpCoin;

		public string m_strLayout;

		public CFarmPvpRank[] m_arrayRank;

		public ulong m_nFreeTimestamp;

		public ushort m_nDiamondCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
