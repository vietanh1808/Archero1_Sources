using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STShipBattleEventCommonReward : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint nId;

		public string strIcon;

		public uint[][] vecReward;

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
