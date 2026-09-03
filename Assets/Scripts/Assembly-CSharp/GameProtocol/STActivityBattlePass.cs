using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityBattlePass : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint nTag;

		public ulong nStartTime;

		public ulong nEndTime;

		public Dictionary<ushort, STActivityBattlePassItem> m_mapItem;

		public uint m_nReceiveExtraRewardCnt;

		public CRewardItem m_stLoopReward;

		public CRewardItem m_stLoopBigReward;

		public uint m_nTotalScore;

		public uint m_nScoreBuyCost;

		public uint nEventId;

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
