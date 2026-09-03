using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivitySixthAnniversarySign : IProtocol
	{
		public ushort m_nTotalDays;

		public STCommonAchievementData[] m_vecRewardData;

		public Dictionary<uint, ushort> m_mapImgConf;

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
