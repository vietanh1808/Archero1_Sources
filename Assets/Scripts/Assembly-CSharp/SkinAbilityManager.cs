using System;
using System.Collections.Generic;
using GameProtocol;
using XLua;

public class SkinAbilityManager : CInstance<SkinAbilityManager>
{
	public const int EquipQuintessenceID = 33050;

	public const int DelicacyTicket = 50001;

	public const int ExaltedTicket = 50002;

	public const int ShineTicket = 50003;

	private static DelegateBridge __Hotfix0_IsReachUnlock;

	private static DelegateBridge __Hotfix0_IsSkinUpgradeUnlock;

	private static DelegateBridge __Hotfix0_HaveHeroSkinRed;

	private static DelegateBridge __Hotfix0_HaveSkinRed;

	private static DelegateBridge __Hotfix0_AddUpgrade;

	private static DelegateBridge __Hotfix0_ResetSkinLevel;

	private static DelegateBridge __Hotfix0_GetHeroName;

	private static DelegateBridge __Hotfix0_GetSkinLevel;

	private static DelegateBridge __Hotfix0_GetMaterialItemData;

	private static DelegateBridge __Hotfix0_ResetRequest;

	private static DelegateBridge __Hotfix0_UpgradeRequest;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsReachUnlock()
	{
		return false;
	}

	public bool IsSkinUpgradeUnlock(int heroSkinID)
	{
		return false;
	}

	public bool HaveHeroSkinRed(int heroID)
	{
		return false;
	}

	public bool HaveSkinRed(int skinID)
	{
		return false;
	}

	public void AddUpgrade(int skinID, int upgrade)
	{
	}

	public void ResetSkinLevel(int skinID)
	{
	}

	public string GetHeroName(int skinID)
	{
		return null;
	}

	public int GetSkinLevel(int skinID)
	{
		return 0;
	}

	public List<SkinAbilityMaterialItemData> GetMaterialItemData(int skinID, float coefficient, int startUpgradeLevel, int endUpgradeLevel)
	{
		return null;
	}

	public void ResetRequest(int skinID, Action<CRespHeroSkin> success = null, Action<CRespHeroSkin> failure = null)
	{
	}

	public void UpgradeRequest(int skinID, int upgrade, Action<CRespHeroSkin> success = null, Action<CRespHeroSkin> failure = null)
	{
	}
}
