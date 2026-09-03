using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityLuckyWheel : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenUserLevel;

		public uint m_nOpenGameLevel;

		public uint m_nSingleDraw;

		public uint m_nTenDraw;

		public ushort m_nFreeTimes;

		public CActivityLuckyWheelTask[] m_vecTasks;

		public string m_strRewardConfig;

		public uint m_nTaskRewardBit;

		public uint m_nProgressRewardBit;

		public ushort m_nRandIndex;

		public CRewardItem[] m_vecRewardItem;

		public uint m_nTotalRollTimes;

		public uint m_nRollTimesLimit;

		public uint m_nBigRewardIndex;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
