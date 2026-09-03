using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRedpacketExchangeData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public short m_nCount;

		public CRewardItem targetItem;

		public CRewardItem[] vecNeedItems;

		public ushort m_ntotalCount;

		public uint m_nId;

		public ushort m_nResetType;

		public ushort m_nPos;

		public ushort m_nDiscount;

		public ushort m_nShopId;

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
