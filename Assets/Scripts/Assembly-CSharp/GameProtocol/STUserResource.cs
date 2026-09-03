using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STUserResource
	{
		public bool m_nChange;

		public ushort m_nBattleRebornCount;

		public ushort m_nNormalDiamondItems;

		public ushort m_nLargeDiamondItems;

		public ushort m_nLife;

		public ushort m_nMixBoxItems;

		public ushort m_nPveSeasonLife;

		public uint m_nPveSeasonSoul;

		public uint m_nPveSeasonCrystal;

		public uint m_nPveScore;

		public ushort m_nDragonBoxItems;

		public ushort m_nTurnKeyCount;

		public ushort m_nRelicsBoxItems;

		public ushort m_nEquipSBoxItems;

		public uint m_nPveSeasonSuperSoul;

		public uint m_nPveScoreNew;

		public ushort m_nCampSeasonLife;

		public uint m_nCampSeasonArrow;

		public uint m_nCampSeasonSuperArrow;

		public uint m_nCampSeasonFood;

		public uint m_nCampSeasonWood;

		public uint m_nCampSeasonIron;

		public uint m_nCampSeasonCrystal;

		public uint m_nCampGold;

		public uint m_nCampSeasonTalent;

		public uint m_nCampSeasonPeerageExp;

		public uint m_nCampStoreCoinA;

		public uint m_nCampStoreCoinB;

		public uint m_nCampTalentBigPoint;

		public uint m_nWorkerBoxCount;

		public uint m_nManorStoreCoin;

		public Dictionary<uint, uint> m_mapOtherResource;

		public ushort m_nBeliefLevel;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
