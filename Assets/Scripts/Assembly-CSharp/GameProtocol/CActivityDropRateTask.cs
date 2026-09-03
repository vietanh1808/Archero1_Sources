using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityDropRateTask : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nTaskType;

		public uint m_nNeedValue;

		public uint m_nProcess;

		public CRewardItem[] vecRewards;

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
