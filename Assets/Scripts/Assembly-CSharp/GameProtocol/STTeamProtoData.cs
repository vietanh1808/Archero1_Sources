using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public class STTeamProtoData
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint nTeamId;

		public string strTeamName;

		public uint nZone;

		public uint nSubZone;

		public uint nCamp;

		public ulong nLeaderRawId;

		public ulong nCreateTs;

		public ushort nTeamState;

		public Dictionary<ulong, STTeamMemberProtoData> m_dicMember;

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
