using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CShipBattleBattlePassStage
	{
		public Dictionary<ushort, ushort> m_mapBattlePassReceived;

		public ushort m_nRewardCnt;

		public ulong nStartTimestamp;

		public ulong nEndTimestamp;

		public ushort nExtraCnt;

		public ushort nExtraCondParam;

		public CRewardItem stReward;

		public CRewardItem stBigReward;

		public uint m_nTotalCostLife;

		public CShipBattleBPRewardConf[] vecBPReward;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
