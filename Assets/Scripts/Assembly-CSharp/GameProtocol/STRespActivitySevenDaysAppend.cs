using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivitySevenDaysAppend : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public string m_strConfs;

		public string m_strItems;

		public string strTasks;

		public uint m_nScore;

		public ulong m_nRewardBoxBits;

		public uint m_nStyleId;

		public ushort m_nShowDays;

		public string m_strGiftBuyCnt;

		public STSevenAppendExchangeData[] vecExchangeData;

		public uint m_nLastExchangeCount;

		public bool m_bDealyTask;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
