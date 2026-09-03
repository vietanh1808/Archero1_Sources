using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityChristmas : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ulong m_nDailyTaskRefreshTime;

		public bool m_bIsNew;

		public ushort m_nRound;

		public uint m_nWishId;

		public ushort m_nWishSelectIdx;

		public uint m_nWishValue;

		public ulong m_nWishRewardBits;

		public uint m_nSignId;

		public uint m_nSignCount;

		public ulong m_nSignRewardBits;

		public uint m_nServerWishValue;

		public uint m_nServerRewardId;

		public ulong m_nServerRewardBits;

		public uint m_nGiftId;

		public string m_strGiftBuyCnt;

		public STActivityChristmasActiveTaskData[] m_vecActiveTasks;

		public STActivityChristmasDailyTaskData[] m_vecDailyTasks;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
