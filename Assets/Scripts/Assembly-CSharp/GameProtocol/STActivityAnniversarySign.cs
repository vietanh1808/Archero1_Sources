using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityAnniversarySign : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public string m_strRewards;

		public ushort m_nDays;

		public ulong m_nRewardBits;

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
