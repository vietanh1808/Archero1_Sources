using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public class STActivityHelpGiftBoxGroupProtoData
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nGroupId;

		public uint m_nSupporterNum;

		public ushort m_nBasePurchased;

		public ushort m_nUltimatePurchased;

		public Dictionary<uint, uint> m_dicSupportGift;

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
