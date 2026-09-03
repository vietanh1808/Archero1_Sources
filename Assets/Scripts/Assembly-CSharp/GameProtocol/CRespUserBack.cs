using System.IO;

namespace GameProtocol
{
	public sealed class CRespUserBack : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ulong m_nEndTime;

		public ushort m_nLoginDays;

		public uint m_nComeBackRewardLog;

		public ushort m_nActive;

		public uint m_nActiveRewardLog;

		public string[] m_vecIapDiscountProductIs;

		public CUserBackRewardsData[] m_vecComeBackRewardsData;

		public CUserBackRewardsData[] m_vecctiveRewardsData;

		public CUserBackIapRewardsData[] m_vecIapDiscountData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
