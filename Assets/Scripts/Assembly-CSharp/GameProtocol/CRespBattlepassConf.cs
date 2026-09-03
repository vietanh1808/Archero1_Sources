using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespBattlepassConf : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong nStartTimestamp;

		public ulong nEndTimestamp;

		public uint m_nBattlepassTag;

		public bool bIsGin;

		public ushort nType;

		public ushort nEventId;

		public CBattlePassExtraRewardConf stExtraReward;

		public CBattlePassRewardConf[] m_arrTagInfo;

		public ushort nMinVersion;

		public ushort nMaxVersion;

		public ushort nSweepAddCnt;

		public ushort nSweepCoinAdd;

		public bool bIsNew;

		public ushort nDropRelicsAdd;

		public ushort nHarvestQuickAdd;

		public ushort nDropBossEggAdd;

		public ushort nRate;

		public Dictionary<ushort, string> mapGameActivityBattlePassPhaseConf;

		public ushort nBayAllBattlePassRate;

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
