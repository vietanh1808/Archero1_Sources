using System;
using System.Collections.Generic;
using XLua;

public sealed class CampBPManager
{
	private static CampBPManager instance;

	private static object Locker;

	public const string BP_NormalPrice = "com.habby.archero_slgbp01";

	public const string BP_PremiumPrice = "com.habby.archero_slgbp02";

	public int Tag;

	public List<byte> RewardState;

	public bool haveBuyBPNormal;

	public bool haveBuyBPPremium;

	public List<CampBPData> BPDataList;

	public int PowerTotal;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge __Hotfix0_requestBPInfo;

	private static DelegateBridge __Hotfix0_isAllReadyGet;

	private static DelegateBridge __Hotfix0_GetBPLevelCurrentValue;

	private static DelegateBridge __Hotfix0_get_GetBPLevelMax;

	private static DelegateBridge __Hotfix0_isHaveRewardCanGet;

	private static DelegateBridge __Hotfix0_GetBPNormalList;

	private static DelegateBridge __Hotfix0_GetBPPremiumList;

	private static DelegateBridge __Hotfix0_GetBPValueAdd;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static CampBPManager Instance => null;

	public int GetBPLevelMax => 0;

	public void requestBPInfo(int type, int rtype, int rid, Action<bool> action = null)
	{
	}

	public bool isAllReadyGet(int id, int index)
	{
		return false;
	}

	public (int, int, int) GetBPLevelCurrentValue()
	{
		return default;
	}

	public bool isHaveRewardCanGet()
	{
		return false;
	}

	public List<int> GetBPNormalList()
	{
		return null;
	}

	public List<int> GetBPPremiumList()
	{
		return null;
	}

	public int GetBPValueAdd(int power)
	{
		return 0;
	}
}
