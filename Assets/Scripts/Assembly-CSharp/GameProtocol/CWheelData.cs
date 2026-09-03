using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CWheelData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nWheelType;

		public ushort m_nMaxFreeCnt;

		public uint m_nDailyMaxCount;

		public uint[] vecPrice;

		public uint[] vecFreeItems;

		public uint[] vecInnerWheel;

		public CWheelRewardData[] vecRewardConfs;

		public ushort m_nBigRewardCnt;

		public ushort m_nFreshCnt;

		public ushort m_nCurrGameLevel;

		public uint m_nDailyCount;

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
