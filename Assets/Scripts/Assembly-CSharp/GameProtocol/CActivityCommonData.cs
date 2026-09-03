using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityCommonData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nType;

		public uint m_nTag;

		public ulong m_nEndTime;

		public string m_strItems;

		public uint m_nCount;

		public ulong m_nRewardFreeId;

		public ulong m_nRewardBuyId;

		public ulong m_nResetTime;

		public bool m_bPurchased;

		public string m_strProductId;

		public uint m_nDiamond;

		public ulong m_nRewardTime;

		public string m_strTitle;

		public ulong m_nStartTime;

		public uint m_nStyleId;

		public uint m_nStarDiamond;

		public uint m_nRate;

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
