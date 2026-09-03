using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class CActivityInvestData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public CActivityInvestCondition[] vecCondition;

		public uint m_nOpenId;

		public bool m_bIsBuy;

		public ulong m_nRewardLog;

		public uint m_nHeroId;

		public ushort m_nGiftType;

		public ulong m_nEndTimestamp;

		public string m_nStrProductId;

		public CActivityInvestRewardData[] m_vecRewardsData;

		public ushort m_nDiscount;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
