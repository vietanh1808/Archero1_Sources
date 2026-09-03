using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityBingo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ushort m_nTag;

		public ushort m_nRewardIndex;

		public ushort m_nBuyCnt;

		public ushort m_nDailyDrawCnt;

		public uint m_nDrawCnt;

		public ulong m_nRewardBits;

		public uint[] m_vecBigLattices;

		public uint[] m_vecOpenLattices;

		public ushort m_nOpenIndex;

		public ushort m_nRound;

		public STActivityBingoTask[] vecTaskData;

		public uint[] m_vecGridRewards;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
