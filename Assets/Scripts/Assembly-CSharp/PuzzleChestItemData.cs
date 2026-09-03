using Activity.Anniversary;
using TableTool;
using XLua;

public class PuzzleChestItemData
{
	private static DelegateBridge __Hotfix0_get_PuzzleChestItemConfigData;

	private static DelegateBridge __Hotfix0_set_PuzzleChestItemConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Condition;

	private static DelegateBridge __Hotfix0_get_ClaimedTaskCount;

	private static DelegateBridge __Hotfix0_get_AllTaskCount;

	private static DelegateBridge __Hotfix0_get_State;

	private static DelegateBridge __Hotfix0_get_GetRewards;

	private static DelegateBridge __Hotfix0_GetState;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge _c__Hotfix0_ctor;

	private PuzzleChestItemConfigData PuzzleChestItemConfigData { get; set; }

	public int ID => 0;

	public int[] Condition => null;

	public int ClaimedTaskCount => 0;

	public int AllTaskCount => 0;

	public JigsawState State => JigsawState.Uncompleted;

	public Drop_DropModel.DropData[] GetRewards => null;

	private JigsawState GetState()
	{
		return JigsawState.Uncompleted;
	}

	public static PuzzleChestItemData Create(PuzzleChestItemConfigData puzzleChestItemConfigData)
	{
		return null;
	}
}
