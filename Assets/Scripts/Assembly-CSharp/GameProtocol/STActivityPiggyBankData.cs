using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityPiggyBankData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nId;

		public string m_strProductId;

		public uint m_nNeedBattle;

		public uint m_nMinDiamond;

		public uint m_nMaxDiamond;

		public ushort m_nDiscount;

		public ushort m_nImg;

		public ushort m_nBuyStatus;

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
