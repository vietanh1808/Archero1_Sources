using System.Collections.Generic;
using XLua;

public class CampTownSkinConfigData
{
	public int useSkinID;

	public List<int> unlockSkinID;

	public List<CampTownSkinItemConfigData> allSkinItemData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge __Hotfix0_SetSkinUseData;

	private static DelegateBridge __Hotfix0_AddSkinUnlockData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static CampTownSkinConfigData Create(int useSkinID, List<int> unlockSkinID, List<CampTownSkinItemConfigData> allSkinItemData)
	{
		return null;
	}

	public void UpdateData(int useSkinID, List<int> unlockSkinID)
	{
	}

	public void SetSkinUseData(int useSkinID)
	{
	}

	public void AddSkinUnlockData(int skinID)
	{
	}
}
