using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STLuckyPlinkoGiftData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nId;

		public ushort m_nPosition;

		public ushort m_nDiscount;

		public uint m_nQuota;

		public uint m_nShow;

		public ushort m_nDailyReset;

		public string m_strProductId;

		public uint[][] m_vecRewards;

		public uint m_nBuyCnt;

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
