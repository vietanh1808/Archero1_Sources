using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityWish : IProtocol
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

		public uint m_nGiftId;

		public string m_strGiftBuyCnt;

		public STActivityWishDailyTaskData[] m_vecDailyTasks;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
