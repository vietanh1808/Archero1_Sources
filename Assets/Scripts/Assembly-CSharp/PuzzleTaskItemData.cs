using Activity.Anniversary;
using TableTool;
using XLua;

public class PuzzleTaskItemData
{
	private static DelegateBridge __Hotfix0_get_PuzzleTaskItemConfigData;

	private static DelegateBridge __Hotfix0_set_PuzzleTaskItemConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_TaskProcess;

	private static DelegateBridge __Hotfix0_get_TaskNeed;

	private static DelegateBridge __Hotfix0_get_State;

	private static DelegateBridge __Hotfix0_get_IsClaimed;

	private static DelegateBridge __Hotfix0_get_GetRewards;

	private static DelegateBridge __Hotfix0_UpdateProcess;

	private static DelegateBridge __Hotfix0_GetState;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge _c__Hotfix0_ctor;

	private PuzzleTaskItemConfigData PuzzleTaskItemConfigData { get; set; }

	public int ID => 0;

	public int TaskProcess => 0;

	public int TaskNeed => 0;

	public JigsawState State => JigsawState.Uncompleted;

	public bool IsClaimed => false;

	public Drop_DropModel.DropData[] GetRewards => null;

	public void UpdateProcess()
	{
	}

	private JigsawState GetState()
	{
		return JigsawState.Uncompleted;
	}

	public static PuzzleTaskItemData Create(PuzzleTaskItemConfigData puzzleTaskItemConfigData)
	{
		return null;
	}
}
