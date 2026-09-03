using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityDropRateType : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nType;

		public string m_strDropRate;

		public string m_strWeightsRate;

		public string m_strDropEquips;

		public string m_strShow;

		public ulong m_nEndTime;

		public CActivityDropRateTask[] m_vecTasks;

		public uint m_nRewardLog;

		public string m_strDropRateShow;

		public ulong m_nBeginTime;

		public string m_strDropTotalRate;

		public string m_strDropUpLimitRate;

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
