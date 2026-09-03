using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameAchieveInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public int m_nTotalDiamonds;

		public uint m_nTotalCoins;

		public ushort m_nLife;

		public ushort m_nBattleRebornCount;

		public ushort m_nNormalDiamondItem;

		public ushort m_nLargeDiamondItem;

		public CEquipmentItem[] m_arrEquipInfo;

		public CGuildAchInfo m_guildAchInfo;

		public ushort m_nMixBoxItem;

		public ushort m_nDragonBoxItem;

		public ushort m_nRelicsBoxItem;

		public ushort m_nEquipSBoxItem;

		public uint m_nWorkerBoxItem;

		public uint m_nPetBoxItem;

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
