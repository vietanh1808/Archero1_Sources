using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityCrazyMonth : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nTag;

		public ushort m_nType;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public STActivityCrazyTask[] vecTaskData;

		public STActivityCrazyGift[] vecGiftData;

		public ushort m_nStyle;

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
