using System.Collections.Generic;
using XLua;

public class CampTalentTeamProgressData : RecycleData<CampTalentTeamProgressConfigData>
{
	private static DelegateBridge __Hotfix0_get_ProgressItemData;

	private static DelegateBridge __Hotfix0_get_IsReachMaxLevel;

	private static DelegateBridge _c__Hotfix0_ctor;

	public List<CampTalentTeamProgressItemData> ProgressItemData => null;

	public bool IsReachMaxLevel => false;
}
