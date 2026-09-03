using System.Collections.Generic;
using TCPPacket.ProtoBuf;
using TableTool;

namespace Cooperation.NetData
{
	public class PlayerInfoData
	{
		public int characterId;

		public int skinId;

		public int weaponSkinId;

		public int weaponSkinLv;

		public int characterLevel;

		public int star;

		public long playerHp;

		public long playerAttack;

		public int integralFactor;

		public uint totalIap;

		public int colorId;

		public List<AddAttStringData> addAttlist;

		public List<AddAttStringData> outsideAttlist;

		public List<LocalSave.CardOne> cardList;

		public List<LocalSave.EquipOne> wearEquip;

		public List<int> refineSkills;

		public List<string> runeAtts;

		public Dictionary<int, EggItem> eggsDic;

		public List<Goods_goods.GoodData> unlockTrains;

		public List<Goods_goods.GoodData> allHeroUnlockTrains;

		public List<LocalSave.CharacterData.LockEffectData> heroUnlocks;

		public List<LocalSave.CharacterData.LockEffectData> allheroesUnLocks;

		public List<LocalSave.EquipOne> relics;

		public LocalSave.WingOne mainWing;

		public List<LocalSave.WingOne> assistWings;

		public LocalSave.WingOne displayWing;

		public List<ArtifactItemData> artifactItemDatas;

		public const string PVP_MODIFY_LOG_TAG = "[PVP修正]";

		private static void IntegralPvPAtt(SelfAttributeData pData)
		{
		}

		public static void IntegralAtt(SelfAttributeData pData, SelfAttributeData pOtherData, double pCoefficient, double pCoefficientOther)
		{
		}

		public static PlayerInfoData CorvertToPlayerInfo(PlayerInfo pNetInfo)
		{
			return null;
		}

		public static PlayerInfo GetNetInfo(PlayerInfoData pInfo)
		{
			return null;
		}

		public static SelfAttributeData GetSelfAttribute()
		{
			return null;
		}

		private static void checkIfSyncEquipAtPos2(PlayerInfoData tdata)
		{
		}

		public static PlayerInfoData GetSelfInfoData()
		{
			return null;
		}

		public void Clear()
		{
		}

		public SelfAttributeData GetAttribute()
		{
			return null;
		}
	}
}
