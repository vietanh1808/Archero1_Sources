using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STAutoDeleteActivityItem : IProtocol
	{
		public Dictionary<ulong, uint> m_mapReplaceItemCount;

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
