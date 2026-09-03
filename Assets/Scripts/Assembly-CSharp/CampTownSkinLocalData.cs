using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class CampTownSkinLocalData : LocalSave.ICloneable<CampTownSkinLocalData>
{
	public int useSkinID;

	public List<int> unlockSkinID;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_SetSkinUseData;

	private static DelegateBridge __Hotfix0_AddSkinUnlockData;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_Clone;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void SetData(int useSkinID, List<int> unlockSkinID)
	{
	}

	public void SetSkinUseData(int useSkinID)
	{
	}

	public void AddSkinUnlockData(int unlockID)
	{
	}

	public void Clear()
	{
	}

	public void Clone(CampTownSkinLocalData source)
	{
	}
}
