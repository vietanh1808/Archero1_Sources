using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityLuckyPlinkoShop : IProtocol
	{
		public STLuckyPlinkoShopData[] m_vecShopData;

		public uint[] m_vecExchangeItemCfg;

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
