using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityDailyTotalChargeReward : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nEndTime;

		public ulong m_nAwardEndTime;

		public string m_strItems;

		public uint m_nTodayTotalCharge;

		public uint m_nTotalChargeDay;

		public ulong m_nRewardBits;

		public bool m_bAccomplishToday;

		public ushort[] m_vecDayRecharge;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
