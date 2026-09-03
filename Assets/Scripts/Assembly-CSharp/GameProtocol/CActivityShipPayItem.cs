using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityShipPayItem : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public string m_strPrice;

		public CRewardItem[] m_vecItems;

		public string[] m_vecNames;

		public ushort m_nIsBuy;

		public uint m_nDiscount;

		public ushort m_nDailyReset;

		public ushort m_nBuyLimit;

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
