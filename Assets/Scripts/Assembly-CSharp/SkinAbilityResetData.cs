using System.Collections.Generic;
using XLua;

public class SkinAbilityResetData
{
	private static DelegateBridge __Hotfix0_get_SkinID;

	private static DelegateBridge __Hotfix0_set_SkinID;

	private static DelegateBridge __Hotfix0_get_SkinLevel;

	private static DelegateBridge __Hotfix0_get_ResetCost;

	private static DelegateBridge __Hotfix0_get_IsEnough;

	private static DelegateBridge __Hotfix0_get_ResetReturnPercent;

	private static DelegateBridge __Hotfix0_get_UpgradePercent;

	private static DelegateBridge __Hotfix0_get_MaterialItemData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetSkinLevel;

	private static DelegateBridge __Hotfix0_GetMaterialItemData;

	private static DelegateBridge __Hotfix0_GetResetCost;

	private static DelegateBridge __Hotfix0_GetResetReturnPercent;

	private static DelegateBridge __Hotfix0_GetUpgradePercent;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int SkinID { get; set; }

	public int SkinLevel => 0;

	public int ResetCost => 0;

	public bool IsEnough => false;

	public int ResetReturnPercent => 0;

	public int UpgradePercent => 0;

	public List<SkinAbilityMaterialItemData> MaterialItemData => null;

	public static SkinAbilityResetData Create(int skinID)
	{
		return null;
	}

	private int GetSkinLevel()
	{
		return 0;
	}

	private List<SkinAbilityMaterialItemData> GetMaterialItemData()
	{
		return null;
	}

	private int GetResetCost()
	{
		return 0;
	}

	private int GetResetReturnPercent()
	{
		return 0;
	}

	private int GetUpgradePercent()
	{
		return 0;
	}
}
