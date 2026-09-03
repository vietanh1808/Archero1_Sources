using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CTActivityYearAwardData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nTag;

		public ulong m_nEndTime;

		public uint m_nWorldActive;

		public uint m_nPersonalActive;

		public ushort m_nBoxRewardLog;

		public uint m_nWorldRewardLog;

		public uint m_nPersonalRewardLog;

		public CRewardItem[] vecBoxRewards;

		public CActivityYearAwardActiveData[] vecWorldActiveData;

		public CActivityYearAwardActiveData[] vecPersonalActiveData;

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
