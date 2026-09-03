using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityHuntingRecord : IProtocol
	{
		public Dictionary<uint, uint> m_mapKillTimes;

		public Dictionary<ushort, uint> m_mapHighScoreBySceneId;

		public Dictionary<ushort, uint> m_mapTotalScoreBySceneId;

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
