using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityAnniversaryTowerDefence : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint[] vecDropItemIds;

		public string m_strItems;

		public ushort m_nMaxSweepCnt;

		public ushort m_nLeftSweepCnt;

		public uint m_nMaxLayer;

		public string m_strLayerData;

		public ushort m_nLifeCost;

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
