using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleBattlepass : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nBattlepassTag;

		public Dictionary<ushort, bool> m_mapIsIAPBattlepass;

		public Dictionary<ushort, bool> m_mapIsIAPBigBattlepass;

		public ushort m_nStage;

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

		public Dictionary<ushort, ushort> m_mapBpStageconf;

		public Dictionary<ushort, CShipBattleBattlePassStage> m_mapStage;

		public ushort m_nBuyCntConf;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
