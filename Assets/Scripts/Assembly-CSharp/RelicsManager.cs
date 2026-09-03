using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class RelicsManager
{
	public const string LOG_TAG = "[Relics]";

	private static RelicsManager instance;

	private static object Locker;

	public RelicSpecialAttributes special;

	private int tridentRelicLevel;

	private const string RELIC_WATCH_AD_TAG = "[RELIC_WATCH_AD_TAG]";

	private bool isUpADCountCD;

	public const string RELIC_SKILL_TAG = "[Relic_Skills]";

	private Dictionary<int, int> fragmentIdToRelicId;

	public static RelicsManager Instance => null;

	public bool isHaveRelicsOne70004 => false;

	public int TridentRelicLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int StarMaxLevel => 0;

	public int MaxLevel => 0;

	private void init()
	{
	}

	public bool IsRelicsUnlocked()
	{
		return false;
	}

	protected int GetPassedStageByMaxLayer(ushort maxLayer)
	{
		return 0;
	}

	public void ShowRelicInfoWindow(int relicsId, bool preview = false)
	{
	}

	private void printDict(Dictionary<string, Goods_goods.GoodData> dict, string typeStr)
	{
	}

	public bool isHaveRelicsOne(int reid)
	{
		return false;
	}

	public bool isHaveRelicsFragment(int reid)
	{
		return false;
	}

	public bool HasRelics()
	{
		return false;
	}

	public LocalSave.EquipOne GetRelicsOne(int reid)
	{
		return null;
	}

	public bool GetIsMaxStar(int reid)
	{
		return false;
	}

	public string GetRelicsInfoStr()
	{
		return null;
	}

	public List<int> GetRelicsByRarity()
	{
		return null;
	}

	public List<int> GetRelicsByRarity(int rarity)
	{
		return null;
	}

	public List<int> GetRelicsListHave()
	{
		return null;
	}

	public void WatchAd(ADCountSource aDCountSource = ADCountSource.eIrregularActivity)
	{
	}

	public void CheckSpecialCountType()
	{
	}

	public void requestRelics(int type, ulong rowid, int equipid, Action action = null)
	{
	}

	public void addRelics(STRelicsItem item)
	{
	}

	public void addRelics(STRelicsItem[] items)
	{
	}

	public int GetNeededMatCount(LocalSave.EquipOne e1)
	{
		return 0;
	}

	public int GetNeededShardCount(LocalSave.EquipOne e1)
	{
		return 0;
	}

	public bool GetLevelUpNeedMat(int reid, int next, ref int star, ref int matid, ref int count, ref int coin, ref bool isNeedUp)
	{
		return false;
	}

	public Dictionary<string, Goods_goods.GoodData> GetAttrInExtraSkill(int reid, int star, int level, int charId, int heroStar, int heroLevel)
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetAttrInLockSkill(int reid, int star, int level, int charId, int heroStar, int heroLevel)
	{
		return null;
	}

	public List<int> GetSkillIdsInLockSkill(int reid, int star, int level, int charId, int heroStar, int heroLevel)
	{
		return null;
	}

	public List<int> GetSkillIdsInExtraSkill(int reid, int star, int level, int charId, int heroStar, int heroLevel)
	{
		return null;
	}

	private bool IsRelicExtraSkillEnabled(int reid, int star, int level, int charId, int heroStar, int heroLevel, int extraSkillId)
	{
		return false;
	}

	public bool IsRelicLockSkillEnabled(int reid, int star, int level, int charId, int heroStar, int heroLevel)
	{
		return false;
	}

	public Dictionary<string, Goods_goods.GoodData> GetAttrBasic(int reid, int star, int level, bool withBasic = true, SelfAttributeData selfAttribute = null)
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetAttrStar(int reid, int star, int level)
	{
		return null;
	}

	public string GetAttrSpecial(int reid, int star, int level)
	{
		return null;
	}

	public string GetSpecialType0Desc(string value)
	{
		return null;
	}

	public List<string> GetAttrSet(int reid, int star, int level)
	{
		return null;
	}

	public bool CanShowRed()
	{
		return false;
	}

	public bool CanShowRed(int relicId)
	{
		return false;
	}

	public bool IsForgeEnabled(LocalSave.EquipOne relicOne)
	{
		return false;
	}

	public bool IsEvolutionEnabled(LocalSave.EquipOne relicOne)
	{
		return false;
	}

	public bool IsStarEnabled(LocalSave.EquipOne relicOne)
	{
		return false;
	}

	public List<int> GetRelicSkillIdsForCampBattle(int charid)
	{
		return null;
	}

	public List<int> GetRelicSkillIdsForDaily124(int charid)
	{
		return null;
	}

	public List<int> GetRelicSkillIds(int charid)
	{
		return null;
	}

	public List<int> GetRelicSetSkillIds()
	{
		return null;
	}

	public List<int> GetRelicSpecialSkillIds()
	{
		return null;
	}

	public List<int> GetRelicsLockSkillIds(int charId)
	{
		return null;
	}

	public List<int> GetRelicsExtraSkillIds(int charId)
	{
		return null;
	}

	public List<int> GetRelicsActiveSkillIds(int charid)
	{
		return null;
	}

	public bool IsSetCollected(int setId)
	{
		return false;
	}

	public int GetSetSkillId(int setId)
	{
		return 0;
	}

	public int GetSetStar(int setId)
	{
		return 0;
	}

	public List<RelicsTextData> GetAttrBasicPreview(Dictionary<string, Goods_goods.GoodData> dict1, Dictionary<string, Goods_goods.GoodData> dict2)
	{
		return null;
	}

	public bool isSpecialType_Effet(int type)
	{
		return false;
	}

	public bool isExtraSpecialType_Effet(int type)
	{
		return false;
	}

	public bool IsSpecialCountType(int type)
	{
		return false;
	}

	public bool IsSpecialChange(int spid, int next)
	{
		return false;
	}

	public string GetSpecialString(int spid, int level)
	{
		return null;
	}

	public int GetSpecialType_TotalValue(int type)
	{
		return 0;
	}

	public RelicsTextData GetAttrSpecialPreview(int reid, int star, int level)
	{
		return null;
	}

	public string FloatToString(float f)
	{
		return null;
	}

	public int GetRelicsId(int frid)
	{
		return 0;
	}

	public bool isHaveExtra(int rid)
	{
		return false;
	}

	public int GetExtraId(int rid)
	{
		return 0;
	}

	public int GetExtraIcon(int rid)
	{
		return 0;
	}

	public string GetExtraName(int rid)
	{
		return null;
	}

	public List<RelicsExtraItemData> GetExtraItemList(int rid)
	{
		return null;
	}

	private List<Relics_ExtraAttributes> getAllExtraAttributesByExtraSkill(int rrid)
	{
		return null;
	}

	public bool isUnlockExtraItemOne(RelicsExtraItemData data)
	{
		return false;
	}

	public bool isHaveEffect_ManorSteal()
	{
		return false;
	}

	public float GetPropDropUpScale(EquipPropType equipPropType)
	{
		return 0f;
	}

	public float GetQuickHarvestExtraAddScale()
	{
		return 0f;
	}

	public float GetGameTurnCoinExtraAddScale()
	{
		return 0f;
	}

	public int SaleRatioInPirateShop_Percent()
	{
		return 0;
	}

	public float SaleRatioInPirateShop()
	{
		return 0f;
	}
}
