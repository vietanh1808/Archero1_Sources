using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivitySixthAnniversaryBattlePass : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public Dictionary<ushort, STActivitySixthAnniversaryBattlePassItem> m_mapItem;

		public uint m_nReceiveExtraRewardCnt;

		public CRewardItem m_stLoopReward;

		public uint m_nTotalScore;

		public uint m_nScoreBuyCost;

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
