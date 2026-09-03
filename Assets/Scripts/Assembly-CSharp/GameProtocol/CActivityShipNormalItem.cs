using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityShipNormalItem : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public uint m_nItemType;

		public uint m_nItemId;

		public uint m_nItemCount;

		public uint m_nSellType;

		public uint m_nPrice;

		public uint m_nDiscountPrice;

		public uint m_nDiscount;

		public ushort m_nIsBuy;

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
