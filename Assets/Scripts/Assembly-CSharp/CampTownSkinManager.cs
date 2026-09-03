using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using XLua;

public class CampTownSkinManager : CInstance<CampTownSkinManager>
{
	private static DelegateBridge __Hotfix0_get_DefaultSkinID;

	private static DelegateBridge __Hotfix0_get_CampTownSkinData;

	private static DelegateBridge __Hotfix0_set_CampTownSkinData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_LateInit;

	private static DelegateBridge __Hotfix0_ReLogin;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_InitData;

	private static DelegateBridge __Hotfix0_GetCampTownSkinData;

	private static DelegateBridge __Hotfix0_GetUseSkinID;

	private static DelegateBridge __Hotfix0_GetAllAttr;

	private static DelegateBridge __Hotfix0_CheckShowGetWindow;

	private static DelegateBridge __Hotfix0_SetCampTownSKinData;

	private static DelegateBridge __Hotfix0_SetSkinUseData;

	private static DelegateBridge __Hotfix0_AddSkinUnlockData;

	private static DelegateBridge __Hotfix0_IsUnLockSkinOne;

	private static DelegateBridge __Hotfix0_get_IsUnLockSkin108;

	private static DelegateBridge __Hotfix0_RequestSkinUse;

	private static DelegateBridge __Hotfix0_RequestSkinBuy;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int DefaultSkinID => 0;

	private CampTownSkinData CampTownSkinData { get; set; }

	public bool IsUnLockSkin108 => false;

	protected override void Init()
	{
	}

	protected override void LateInit()
	{
	}

	protected override void ReLogin()
	{
	}

	protected override void Clear()
	{
	}

	private void InitData()
	{
	}

	public CampTownSkinData GetCampTownSkinData()
	{
		return null;
	}

	public int GetUseSkinID()
	{
		return 0;
	}

	public List<string> GetAllAttr()
	{
		return null;
	}

	public void CheckShowGetWindow(List<Drop_DropModel.DropData> allDropData)
	{
	}

	public void SetCampTownSKinData(int curUseSkinID, List<int> unlockSkinID)
	{
	}

	public void SetSkinUseData(int useSkinID)
	{
	}

	public void AddSkinUnlockData(int unlockSKinID)
	{
	}

	public bool IsUnLockSkinOne(int skinid)
	{
		return false;
	}

	public void RequestSkinUse(int skinID, Action<CRespCampSeasonHome> success = null, Action<CRespCampSeasonHome> failure = null)
	{
	}

	public void RequestSkinBuy(int skinID, Action<CRespCampSeasonHome> success = null, Action<CRespCampSeasonHome> failure = null)
	{
	}
}
