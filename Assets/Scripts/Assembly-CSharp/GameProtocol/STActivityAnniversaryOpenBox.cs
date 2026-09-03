using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityAnniversaryOpenBox : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint[] vecDropItemIds;

		public ushort[] vecTimeSpent;

		public STActivityAnniversaryTask[] vecTaskData;

		public STAnniExchangeData[] vecExchangeData;

		public uint nExchangeCount;

		public ushort nRewardCount;

		public ushort nNeedCount;

		public ushort nMaxRewardCount;

		public string strBoxRewards;

		public uint nKeyCount;

		public string strOpeningBox;

		public ushort nLayerIndex;

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
