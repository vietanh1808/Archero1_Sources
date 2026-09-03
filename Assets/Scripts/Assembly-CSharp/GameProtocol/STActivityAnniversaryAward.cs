using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityAnniversaryAward : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ushort[] m_vecPercent;

		public string m_strServerItems;

		public uint m_nServerValue;

		public ulong m_nServerRewardBits;

		public STActivityAnniversaryTask[] vecPersonalTaskData;

		public STActivityAnniversaryTask[] sortedPersonalTaskData;

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
