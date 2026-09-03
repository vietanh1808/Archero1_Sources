using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CWheelRewardData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint nId;

		public uint nPositon;

		public bool bDone;

		public uint nWeightShow;

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
