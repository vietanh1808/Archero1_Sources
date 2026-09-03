using XLua;

public class FishingSceneData : RecycleData<FishingSceneConfigData>
{
	private static DelegateBridge __Hotfix0_get_MaxUnlockSceneID;

	private static DelegateBridge __Hotfix0_IsUnlock;

	private static DelegateBridge __Hotfix0_UnlockNeedWeight;

	private static DelegateBridge __Hotfix0_get_CurSelectArea;

	private static DelegateBridge __Hotfix0_get_AllAreaID;

	private static DelegateBridge __Hotfix0_get_CurSelectIndex;

	private static DelegateBridge __Hotfix0_get_MaxUnlockSceneIndex;

	private static DelegateBridge __Hotfix0_get_HaveUnlockMaxSceneID;

	private static DelegateBridge __Hotfix0_IsMaxUnlockIndex;

	private static DelegateBridge __Hotfix0_GetMaxUnlockSceneID;

	private static DelegateBridge __Hotfix0_GetNextSceneWeightTarget;

	private static DelegateBridge __Hotfix0_SetUseArea;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int MaxUnlockSceneID => 0;

	public int CurSelectArea => 0;

	public int[] AllAreaID => null;

	public int CurSelectIndex => 0;

	public int MaxUnlockSceneIndex => 0;

	public bool HaveUnlockMaxSceneID => false;

	public bool IsUnlock(int areaID)
	{
		return false;
	}

	public int UnlockNeedWeight(int areaID)
	{
		return 0;
	}

	public bool IsMaxUnlockIndex(int index)
	{
		return false;
	}

	private int GetMaxUnlockSceneID()
	{
		return 0;
	}

	private int GetNextSceneWeightTarget()
	{
		return 0;
	}

	public void SetUseArea(int areaID)
	{
	}
}
