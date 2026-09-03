using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespInAppPurchase : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strIAPTransID;

		public uint m_nTotalCoins;

		public int m_nTotalDiamonds;

		public ushort m_nBattleRebornCount;

		public ushort m_nNormalDiamondItems;

		public ushort m_nLargeDiamondItems;

		public CEquipmentItem[] m_arrEquipInfo;

		public ushort m_nLife;

		public STHeadItem[] m_arrHeadItem;

		public CMonsterEgg[] m_vecMonsterEgg;

		public ulong m_nMonthCardExpiresTimestamp;

		public uint m_nTotalCash;

		public uint m_nPurcahseInTowWeeks;

		public uint m_nLatest3PurchaseAvg;

		public ushort m_nMixBoxKeyItems;

		public ushort m_nDragonBoxKeyItems;

		public uint m_nPveSoul;

		public uint m_nPveCrystal;

		public ushort m_nPveLife;

		public STCarvingItem[] m_vecCarvingData;

		public ushort m_nVipLevel;

		public uint m_nVipScore;

		public ushort m_nRelicsBoxItems;

		public STRelicsItem[] m_vecRelicsData;

		public CWeaponSkin[] m_vecWeaponSkinData;

		public CHeroSkin[] m_arraySkin;

		public ushort m_nEquipSBoxItems;

		public uint m_nPveSuperSoul;

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

		public uint m_nWorkerBoxCount;

		public uint m_nManorStoreCoin;

		public CManorWoker[] m_vecWorkerData;

		public uint m_nCampTalentBigPoint;

		public uint[] m_arraySkins;

		public STPetInfo[] m_vecPetInfo;

		public uint m_nPetBoxCount;

		public int m_nVipScoreCilent;

		public int m_nTotalStarDiamond;

		public long m_nTotalCoinsInt64;

		public uint m_nImprintBoxCount;

		public CImprintInfo[] m_vecImprintData;

		public uint m_nImprintBless;

		public CWing[] m_vecWings;

		public Dictionary<uint, uint> m_mapOtherResource;

		public uint[] vecShipBattleShipSkin;

		public CArtifact[] m_vecArtifactArray;

		public CTotem[] m_vecTotem;

		public CColorfulWeaponSkin[] m_vecColorfulWeaponSkin;

		public string product_id;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
