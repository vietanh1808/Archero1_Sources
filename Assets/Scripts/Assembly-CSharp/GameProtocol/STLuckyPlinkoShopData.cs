using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STLuckyPlinkoShopData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nId;

		public ushort m_nPosition;

		public ushort m_nDiscount;

		public uint m_nCount;

		public ushort m_nDailyReset;

		public uint[][] m_vecPrice;

		public uint[][] m_vecProduct;

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
