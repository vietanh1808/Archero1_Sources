using System.Collections.Generic;
using XLua;

public class CampTownSkinData : RecycleData<CampTownSkinConfigData>
{
	private static DelegateBridge __Hotfix0_get_UseSkinID;

	private static DelegateBridge __Hotfix0_get_UnlockSkinID;

	private static DelegateBridge __Hotfix0_get_CurUseSKinItemData;

	private static DelegateBridge __Hotfix0_get_UnlockSKinItemData;

	private static DelegateBridge __Hotfix0_get_AllSkinItemData;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge __Hotfix0_SetSkinUseData;

	private static DelegateBridge __Hotfix0_AddSkinUnlockData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int UseSkinID => 0;

	public List<int> UnlockSkinID => null;

	public CampTownSkinItemData CurUseSKinItemData => null;

	public List<CampTownSkinItemData> UnlockSKinItemData => null;

	public List<CampTownSkinItemData> AllSkinItemData => null;

	public void UpdateData(int useSkinID, List<int> unlockSkinID)
	{
	}

	public void SetSkinUseData(int useSkinID)
	{
	}

	public void AddSkinUnlockData(int unlockSKinID)
	{
	}
}
