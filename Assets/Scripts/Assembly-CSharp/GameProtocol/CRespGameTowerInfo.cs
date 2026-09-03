using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameTowerInfo : IProtocol
	{
		public uint m_nLayer;

		public ushort m_nTowerLife;

		public CCommonRespMsg m_stRetMsg;

		public uint m_nTotalDiamonds;

		public uint m_nTotalCoins;

		public uint m_nLife;

		public uint m_nBattleRebornCount;

		public uint m_nNormalDiamondItem;

		public uint m_nLargeDiamondItem;

		public ushort m_nLevel;

		public uint m_nExperience;

		public CEquipmentItem[] m_arrEquipInfo;

		public uint m_nHeroLayer;

		public CMonsterEgg[] m_vecMonsterEgg;

		public uint m_nDragonBoxItem;

		public ulong m_nExperienceInt64;

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
