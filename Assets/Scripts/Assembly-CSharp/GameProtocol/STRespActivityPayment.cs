using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityPayment : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nAwardEndTime;

		public uint m_nOpenGameLevel;

		public ushort m_nProgressMax;

		public string m_strItems;

		public string strTasks;

		public uint m_nPayScore;

		public ushort m_nTaskProgress;

		public ulong m_nRewardBits;

		public ulong m_nRewardBoxBits;

		public string m_strTaskRewards;

		public ushort m_nBoxRewardCnt;

		public uint m_nStyleId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
