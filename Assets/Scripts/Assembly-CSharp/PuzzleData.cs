using XLua;

public class PuzzleData
{
	private static DelegateBridge __Hotfix0_get_PuzzleConfigData;

	private static DelegateBridge __Hotfix0_set_PuzzleConfigData;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_SyncData;

	private static DelegateBridge __Hotfix0_HaveData;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge _c__Hotfix0_ctor;

	private PuzzleConfigData PuzzleConfigData { get; set; }

	public long LeftTime => 0L;

	public bool IsOpen => false;

	public void SyncData(PuzzleConfigData puzzleConfigData)
	{
	}

	public bool HaveData()
	{
		return false;
	}

	public void Clear()
	{
	}
}
