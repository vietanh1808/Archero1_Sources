using System;
using System.Collections.Generic;
using TableTool;

public class DropManager
{
	public class DropData
	{
		public int EquipProb;
	}

	private class SoldierDropDataOne
	{
		public int dropid;

		public float percent;

		public bool GetRandom()
		{
			return false;
		}
	}

	private class SoldierDropData
	{
		public List<SoldierDropDataOne> list;

		private List<int> mRandomList;

		public List<int> RandomDropIds()
		{
			return null;
		}
	}

	private List<BattleDropData> m_listDropEquipsInEndlessMode;

	private const string Tag = "DropManager";

	public const int FETTER_BADGE_ID = 31002;

	public const int SKILL_STONE_ID = 38205;

	private const int percentnumber = 100000000;

	private long level_dropequip;

	private DropData mDropData;

	private bool equip_talent_enable;

	private bool equipexp_talent_enable;

	private bool equip_must_drop;

	private bool type_401or402_equip_must_drop;

	private bool type_magicbook_equip_must_drop;

	public int TotalEquipDropCount;

	public int TotalScrollDropCount;

	public int TotalActivityPropDropCount;

	public int TotalStoneDropCount;

	public int TotalBloodStoneDropCount;

	public int TotalFetterBadgeDropCount;

	public int TotalSkillStoneDropCount;

	public int TotalTDItemDropCount;

	public int TotalAct4thItemsDropCount;

	public int TotalAct4thExchangeItemsDropCount;

	public int TotalBookDropCount;

	public int TotalRuneStoneDropCount;

	public int TotalCookieDropCount;

	public int TotalSoulStoneDropCount;

	public int TotalAdventureCoinCount;

	public int TotalHonorStoneCount;

	public int TotalLoupeCount;

	public int TotalBoneCount;

	public int TotalHornCount;

	public int TotalMagicStoneDropCount;

	public int TotalDragonCoinDropCount;

	public int TotalStarLightStoneDropCount;

	public int TotalWishCoinCount;

	public int TotalRelicFragCount;

	public int TotalModstoneCount;

	public int TotalCommonItemCount;

	public int TotalEquipQuintessenceDropCount;

	public int TotalPetLevelUpItemsCount;

	public int TotalPetExchangeItemsCount;

	public int TotalAct5thDonateItemsCount;

	public int TotalNewPlay125BagCoinItemsCount;

	public int TotalImprintLevelUpItemsCount;

	public int TotalImprintExchangeItemsCount;

	public int TotalImprintStoneItemsCount;

	public int TotalWingLevelUpItemsCount;

	private Dictionary<int, int> m_dicTotalDrops;

	public bool Gem_Must_Drop_61101;

	public int GemHaveAdd;

	public int GemHaveTotal;

	public int GemConfigAdd;

	public int GemConfigDropId;

	public List<int> killMonsterSpecialDropList;

	private BattleDropData battle_drop_temp;

	private const int DropIdAllRate = 10000;

	private Dictionary<int, SoldierDropData> mSoldierDropList;

	private List<Drop_DropModel.DropData> equiplist;

	private bool can_drop;

	private bool CheckEquipMinDrop => false;

	public int TotalSoulPontCount { get; private set; }

	public void Reset()
	{
	}

	public void CalDropEquipsInEndlessMode()
	{
	}

	private void _CalDropEquipsExp(int layer, int id)
	{
	}

	private void _CalDropEquips(int layer, int id)
	{
	}

	private void _CalDropStones(int layer, int count)
	{
	}

	public List<BattleDropData> GetDropEquipsInEndlessMode()
	{
		return null;
	}

	private void Reset_Level()
	{
	}

	public void GetRandomLevel(ref List<BattleDropData> list, int guid, Soldier_soldier data, float randomEquipAdditionValue = 0f)
	{
	}

	private void handleMonsterEgg(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	public void GetRandomGoldHitted(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetActivityProp(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetBloodStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetRandomFetterBadge(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetRandomSkillStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetWishCoin(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetModstone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetCommonItem(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetDropMat(int id, ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetRuneStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetCookie(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetAdventureCoin(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetLoupeDrops(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetManorMat(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetSoulStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetBone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetHorn(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetRandomEquipExp(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetRandomMagicStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetRandomDragonCoin(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetRandomStarLightStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void sendNaturalDropWrapper(int equipId)
	{
	}

	private void GetRandomEquip(ref List<BattleDropData> list, int guid, Soldier_soldier data, float randomAdditionValue = 0f)
	{
	}

	private void GetDropIds(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private List<BattleDropData> GetDropList()
	{
		return null;
	}

	public static int getTotalCnt(Dictionary<int, int> dic, Func<LocalSave.EquipOne, bool> condition)
	{
		return 0;
	}

	public static int getTotalCnt(Dictionary<int, int> dic, LocalSave.EquipOne one)
	{
		return 0;
	}

	private bool CanGetMoreDrop(LocalSave.EquipOne equipOne)
	{
		return false;
	}

	private void AppendDropCount(LocalSave.EquipOne equipOne)
	{
	}

	public List<LocalSave.EquipOne> GetValidDropList2(List<LocalSave.EquipOne> list)
	{
		return null;
	}

	public static void GetValidDropList(List<LocalSave.EquipOne> equipList, List<LocalSave.EquipOne> limitList)
	{
	}

	private static int checkSameTypeEquip(int equipId, Dictionary<int, int> owned)
	{
		return 0;
	}

	private void handleGemsDrop(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_Act4thItems(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void HandleDrop_Act4thExchangeItems(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetEquipQuintessence(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_PetLevelUp(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_PetExchange(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_ArtifactMat(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_ImprintLevelUp(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_ImprintExchange(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_ImprintStone(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_WingLevelUp(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void handleDrop_Act5Donate(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void GetNewPlay125BagCoin(ref List<BattleDropData> list, Soldier_soldier data)
	{
	}

	private void TryAddNewPlay125Drop(ref List<BattleDropData> list, int count)
	{
	}

	public void ResetSeason()
	{
	}
}
