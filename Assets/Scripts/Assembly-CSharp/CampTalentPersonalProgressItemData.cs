using System.Collections.Generic;
using TableTool;
using XLua;

public class CampTalentPersonalProgressItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_Model;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Level;

	private static DelegateBridge __Hotfix0_get_MaxLevel;

	private static DelegateBridge __Hotfix0_get_IsMaxLevel;

	private static DelegateBridge __Hotfix0_get_CurLevelNeedTalentLevel;

	private static DelegateBridge __Hotfix0_get_IsUnlock;

	private static DelegateBridge __Hotfix0_get_IsReachTotalTalentLevelCond;

	private static DelegateBridge __Hotfix0_get_IsReachTalentCond;

	private static DelegateBridge __Hotfix0_get_CanUpgrade;

	private static DelegateBridge __Hotfix0_get_IsHaveEnoughCurrency;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_get_LineDir;

	private static DelegateBridge __Hotfix0_get_UpgradeLine;

	private static DelegateBridge __Hotfix0_get_UpgradeNeedCount;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_ReachTotalTalentLevelCond;

	private static DelegateBridge __Hotfix0_ReachTalentCond;

	private static DelegateBridge __Hotfix0_HaveEnoughCurrency;

	private static DelegateBridge __Hotfix0_GetUpgradeNeedCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTalentPersonalProgressItemConfigData ConfigData { get; set; }

	public SLG_Talent Model => null;

	public int ID => 0;

	public int Level => 0;

	public int MaxLevel => 0;

	public bool IsMaxLevel => false;

	public int CurLevelNeedTalentLevel => 0;

	public bool IsUnlock => false;

	public bool IsReachTotalTalentLevelCond => false;

	public bool IsReachTalentCond => false;

	public bool CanUpgrade => false;

	public bool IsHaveEnoughCurrency => false;

	public (int, int) Position => default;

	public CampTalentLineDir LineDir => CampTalentLineDir.None;

	public CampTalentLineDir UpgradeLine => CampTalentLineDir.None;

	public int UpgradeNeedCount => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static CampTalentPersonalProgressItemData Create(CampTalentPersonalProgressItemConfigData configData)
	{
		return null;
	}

	private bool ReachTotalTalentLevelCond()
	{
		return false;
	}

	private bool ReachTalentCond()
	{
		return false;
	}

	private bool HaveEnoughCurrency()
	{
		return false;
	}

	private int GetUpgradeNeedCount()
	{
		return 0;
	}
}
