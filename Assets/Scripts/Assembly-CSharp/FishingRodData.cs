using System.Collections.Generic;
using XLua;

public class FishingRodData : RecycleData<FishingRodConfigData>
{
	private static DelegateBridge __Hotfix0_get_UseRodID;

	private static DelegateBridge __Hotfix0_get_UseRodType;

	private static DelegateBridge __Hotfix0_get_PossessRodID;

	private static DelegateBridge __Hotfix0_GetRodType;

	private static DelegateBridge __Hotfix0_UpdateRod;

	private static DelegateBridge __Hotfix0_GetMaxUnlockRodID;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int UseRodID => 0;

	public FishingRodType UseRodType => FishingRodType.None;

	public List<int> PossessRodID => null;

	public FishingRodType GetRodType(int id)
	{
		return FishingRodType.None;
	}

	public void UpdateRod()
	{
	}

	public int GetMaxUnlockRodID(int allWeight)
	{
		return 0;
	}
}
