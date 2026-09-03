using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityLuckyPlinkoGrid : IProtocol
	{
		public Dictionary<ushort, STLuckyPlinkoGridData> m_mapGridData;

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
