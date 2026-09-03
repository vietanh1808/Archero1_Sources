using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityInvest : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public CActivityInvestCondition[] vecCondition;

		public uint m_nOpenId;

		public bool m_bIsBuy;

		public ulong m_nRewardLog;

		public uint m_nHeroId;

		public ushort m_nGiftType;

		public ulong m_nEndTimestamp;

		public string m_nStrProductId;

		public CActivityInvestRewardData[] m_vecRewardsData;

		public CActivityInvestData cInvestGemData;

		public CActivityInvestData cInvestDiamondsData;

		public CActivityInvestData cInvestHeroData;

		public CActivityInvestData cInvestRelicsData;

		public CActivityInvestData cInvestPetData;

		public ushort m_nDiscount;

		public CActivityInvestData cInvestWingData;

		public CActivityInvestData cInvestArtifactData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
