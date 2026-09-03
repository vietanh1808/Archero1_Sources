using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CWorldCupExchangeData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public CRewardItem targetItem;

		public CRewardItem[] vecNeedItems;

		public ushort m_nTotalCount;

		public short m_nCount;

		public ushort m_nOpenGamelLevel;

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
