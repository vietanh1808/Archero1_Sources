using System.IO;

namespace GameProtocol
{
	public sealed class CRestoreItem
	{
		public enum EItemIndex
		{
			ELifeItemIndex = 0,
			ENormalDiamondItemIndex = 1,
			ELargeDiamondItemIndex = 2,
			EAdGetLifeItemIndex = 3,
			EAdGetLuckyItemIndex = 4,
			eLifeTrustIndex = 5,
			EAdStrengthItemIndex = 6,
			EMystShopHeroFragIndex = 7,
			EBuyLifeIndex = 8,
			EMixBoxIndex = 9,
			EDragonBoxIndex = 10,
			EBoxRelicsIndex = 11,
			EBoxEquipSIndex = 12,
			EBoxManorIndex = 13,
			EPetBoxIndex = 14,
			EImprintBoxIndex = 15,
			EInvalidItemIndex = 16
		}

		public short m_nMin;

		public ushort m_nMax;

		public ulong m_i64Timestamp;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
