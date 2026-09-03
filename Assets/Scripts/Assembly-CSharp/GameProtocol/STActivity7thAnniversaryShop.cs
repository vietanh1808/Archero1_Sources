using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivity7thAnniversaryShop : IProtocol
	{
		public STCommonShopData[] m_vecShopData1;

		public STCommonShopData[] m_vecShopData2;

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
