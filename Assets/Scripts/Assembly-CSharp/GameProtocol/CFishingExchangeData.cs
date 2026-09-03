using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CFishingExchangeData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public short m_nCount;

		public CRewardItem[] vecTargetItems;

		public ushort m_ntotalCount;

		public uint m_nId;

		public ushort m_nPos;

		public ushort m_nDiscount;

		public uint m_nUnlockWeight;

		public CRewardItem[] m_vecPrice;

		public ushort m_nDailyReset;

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
