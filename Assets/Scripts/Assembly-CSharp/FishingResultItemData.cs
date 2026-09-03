using TableTool;
using XLua;

public class FishingResultItemData
{
	private static DelegateBridge __Hotfix0_get_Prop;

	private static DelegateBridge __Hotfix0_set_Prop;

	private static DelegateBridge __Hotfix0_get_Weight;

	private static DelegateBridge __Hotfix0_set_Weight;

	private static DelegateBridge __Hotfix0_get_IsFish;

	private static DelegateBridge __Hotfix0_get_FishType;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge _c__Hotfix0_ctor;

	public Drop_DropModel.DropData Prop { get; set; }

	public int Weight { get; set; }

	public bool IsFish => false;

	public FishingFishType FishType => FishingFishType.None;

	public static FishingResultItemData Create(Drop_DropModel.DropData prop, int weight)
	{
		return null;
	}
}
