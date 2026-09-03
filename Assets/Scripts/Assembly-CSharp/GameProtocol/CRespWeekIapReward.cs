using System.IO;

namespace GameProtocol
{
	public sealed class CRespWeekIapReward : IProtocol
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

		public ushort m_nMixBoxKeyItem;

		public bool m_bIsAdReward;

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
