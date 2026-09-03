using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityMonopolyShop : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public STCommonShopData[] m_vecShopData;

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
