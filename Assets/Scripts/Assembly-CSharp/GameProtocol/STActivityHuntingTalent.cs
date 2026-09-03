using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityHuntingTalent : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public Dictionary<ushort, ushort> m_mapTalentData;

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
