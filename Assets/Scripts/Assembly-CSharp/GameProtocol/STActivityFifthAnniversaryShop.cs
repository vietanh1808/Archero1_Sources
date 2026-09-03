using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityFifthAnniversaryShop : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

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
