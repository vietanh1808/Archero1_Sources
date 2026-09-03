using System.IO;

namespace GameProtocol
{
	public sealed class CRespDailyIapReward : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public int m_nTotalDiamonds;

		public uint m_nTotalCoins;

		public ushort m_nLife;

		public ushort m_nBattleRebornCount;

		public ushort m_nNormalDiamondItem;

		public ushort m_nLargeDiamondItem;

		public CEquipmentItem[] m_arrEquipInfo;

		public string jsonDailyIAPInfo;

		public bool m_bIsAdReward;

		public ushort m_nMixBoxKeyItem;

		public ushort m_nDragonBoxKeyItem;

		public ulong m_nFreeTimestamp;

		public STCarvingItem[] m_vecCarvingData;

		public STRelicsItem[] m_vecRelicsData;

		public ushort m_nRelicsBoxKeyItem;

		public ushort m_nEquipSBoxKeyItem;

		public uint m_nWorkerBoxKeyItem;

		public long m_nTotalCoinsInt64;

		public uint m_nImprintBoxItem;

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
