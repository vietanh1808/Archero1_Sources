using System.Collections.Generic;
using XLua;

public class CampTalentPersonalProgressData : RecycleData<CampTalentProgressConfigData>
{
	private static DelegateBridge __Hotfix0_get_ProgressItemData;

	private static DelegateBridge __Hotfix0_GetProgressItemData;

	private static DelegateBridge __Hotfix0_get_MaxProgressItemCount;

	private static DelegateBridge __Hotfix1_GetProgressItemData;

	private static DelegateBridge __Hotfix0_TalentUpgrade;

	private static DelegateBridge _c__Hotfix0_ctor;

	public List<CampTalentPersonalProgressItemData> ProgressItemData => null;

	public int MaxProgressItemCount => 0;

	public CampTalentPersonalProgressItemData GetProgressItemData(int row, int col)
	{
		return null;
	}

	public CampTalentPersonalProgressItemData GetProgressItemData(int id)
	{
		return null;
	}

	public void TalentUpgrade(int id)
	{
	}
}
