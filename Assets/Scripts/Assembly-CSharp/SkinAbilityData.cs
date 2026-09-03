using System.Collections.Generic;
using XLua;

public class SkinAbilityData
{
	private static DelegateBridge __Hotfix0_get_SkinID;

	private static DelegateBridge __Hotfix0_set_SkinID;

	private static DelegateBridge __Hotfix0_get_ModelID;

	private static DelegateBridge __Hotfix0_get_SkinLevel;

	private static DelegateBridge __Hotfix0_get_SkinAttack;

	private static DelegateBridge __Hotfix0_get_NextLevelAddAttack;

	private static DelegateBridge __Hotfix0_get_SkinBlood;

	private static DelegateBridge __Hotfix0_get_NextLevelAddBlood;

	private static DelegateBridge __Hotfix0_get_CanUpgrade;

	private static DelegateBridge __Hotfix0_get_MaxLevel;

	private static DelegateBridge __Hotfix0_get_IsMaxLevel;

	private static DelegateBridge __Hotfix0_get_SkinMaxLevel;

	private static DelegateBridge __Hotfix0_get_IsSkinMaxLevel;

	private static DelegateBridge __Hotfix0_get_MaxUpgradeLevel;

	private static DelegateBridge __Hotfix0_get_AbilityItemData;

	private static DelegateBridge __Hotfix0_get_MaterialItemData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetSkinAttack;

	private static DelegateBridge __Hotfix0_GetSkinBlood;

	private static DelegateBridge __Hotfix0_GetMaterialItemData;

	private static DelegateBridge __Hotfix0_GetModelID;

	private static DelegateBridge __Hotfix0_GetAddAttr;

	private static DelegateBridge __Hotfix0_GetSkinLevel;

	private static DelegateBridge __Hotfix0_GetMaxLevel;

	private static DelegateBridge __Hotfix0_GetSkinMaxLevel;

	private static DelegateBridge __Hotfix0_GetAbilityItemData;

	private static DelegateBridge __Hotfix0_GetMaxUpgradeLevel;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int SkinID { get; set; }

	public int ModelID => 0;

	public int SkinLevel => 0;

	public int SkinAttack => 0;

	public int NextLevelAddAttack => 0;

	public int SkinBlood => 0;

	public int NextLevelAddBlood => 0;

	public bool CanUpgrade => false;

	public int MaxLevel => 0;

	public bool IsMaxLevel => false;

	public int SkinMaxLevel => 0;

	public bool IsSkinMaxLevel => false;

	public int MaxUpgradeLevel => 0;

	public List<SkinAbilityItemData> AbilityItemData => null;

	public List<SkinAbilityMaterialItemData> MaterialItemData => null;

	public static SkinAbilityData Create(int skinID)
	{
		return null;
	}

	public int GetSkinAttack(int level)
	{
		return 0;
	}

	public int GetSkinBlood(int level)
	{
		return 0;
	}

	public List<SkinAbilityMaterialItemData> GetMaterialItemData(int addLevel)
	{
		return null;
	}

	private int GetModelID()
	{
		return 0;
	}

	private int GetAddAttr(string attrName, int level)
	{
		return 0;
	}

	private int GetSkinLevel()
	{
		return 0;
	}

	private int GetMaxLevel()
	{
		return 0;
	}

	private int GetSkinMaxLevel()
	{
		return 0;
	}

	private List<SkinAbilityItemData> GetAbilityItemData()
	{
		return null;
	}

	private int GetMaxUpgradeLevel()
	{
		return 0;
	}
}
