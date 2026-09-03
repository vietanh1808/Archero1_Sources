using System.IO;

namespace GameProtocol
{
	public sealed class CRespQueryItems : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CEquipmentItem[] m_arrayEquipData;

		public int m_nTotalDiamonds;

		public uint m_nTotalCoins;

		public ushort m_nLife;

		public uint m_nBattleRebornCount;

		public uint m_nNormalDiamondItem;

		public uint m_nLargeDiamondItem;

		public uint m_nMixBoxCount;

		public uint m_nDragonBoxKeyCount;

		public ushort m_nVipLevel;

		public uint m_nVipScore;

		public uint m_nRelicsBoxKeyCount;

		public uint m_nEquipSBoxKeyCount;

		public uint m_nWorkerBoxKeyCount;

		public uint m_nPetBoxKeyCount;

		public long m_nCoinsInt64;

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
