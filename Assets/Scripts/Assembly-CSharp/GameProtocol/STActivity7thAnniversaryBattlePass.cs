using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivity7thAnniversaryBattlePass : IProtocol
	{
		public Dictionary<ushort, STActivity7thAnniversaryBattlePassItem> m_mapItem;

		public uint m_nReceiveExtraRewardCnt;

		public CRewardItem m_stLoopReward;

		public CRewardItem m_stLoopBigReward;

		public uint m_nTotalScore;

		public uint m_nScoreBuyCost;

		public uint m_nReceiveExtraRewardCntLimit;

		public uint m_nConditionScore;

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
