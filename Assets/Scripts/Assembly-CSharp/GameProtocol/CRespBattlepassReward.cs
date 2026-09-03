using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespBattlepassReward : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public int m_nTotalDiamonds;

		public uint m_nTotalCoins;

		public ushort m_nLife;

		public ushort m_nBattleRebornCount;

		public ushort m_nNormalDiamondItem;

		public ushort m_nLargeDiamondItem;

		public ulong m_nKillCounts;

		public CEquipmentItem[] m_arrEquipInfo;

		public uint m_nBattlepassTag;

		public ulong m_i64BattleKillCounts;

		public byte[] m_arrBattlepassMask;

		public bool m_bIsIAPBattlepass;

		public ushort m_nRewardCnt;

		public bool m_bIsIAPBigBattlepass;

		public long m_nTotalCoinsInt64;

		public bool m_bIsIAPPermanentBattlepass;

		public bool m_bIsIAPPermanentBigBattlepass;

		public Dictionary<ushort, STActivityBattlePass> m_mapBattlePass;

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
