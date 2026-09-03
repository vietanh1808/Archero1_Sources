using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityFifthAnniversaryAward : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ushort m_nDonatePerCount;

		public uint m_nDonateMax;

		public uint[] m_vecPercent;

		public STActivity5thAnniRewardData[] vecRewardData;

		public STActivity5thAnniRewardData[] vecDonateRewardData;

		public STActivity5thAnniRewardData[] vecEndlessDonateRewardData;

		public uint m_nServerValue;

		public ulong m_nServerRewardBits;

		public uint m_nDonateValue;

		public uint m_nDonateUnit;

		public ushort m_nDonateBoxCnt;

		public uint m_nTotalDonate;

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
