using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STCommonQuickBuyData : IProtocol
	{
		public uint m_nItemId;

		public uint m_nBuyTimes;

		public uint m_nBuyTimesLimit;

		public uint m_nBuyPrice;

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
