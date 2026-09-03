using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CTActivityYearBossData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nTag;

		public ulong m_nEndTime;

		public string m_strRewards;

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
