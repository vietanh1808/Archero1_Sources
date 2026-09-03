using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityPirateTreasureGift : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public string m_strGiftCfg;

		public string m_strGiftBuyCnt;

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
