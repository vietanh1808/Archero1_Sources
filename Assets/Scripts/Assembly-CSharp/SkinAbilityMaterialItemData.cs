using TableTool;
using XLua;

public class SkinAbilityMaterialItemData
{
	private static DelegateBridge __Hotfix0_get_PropID;

	private static DelegateBridge __Hotfix0_set_PropID;

	private static DelegateBridge __Hotfix0_get_PropType;

	private static DelegateBridge __Hotfix0_set_PropType;

	private static DelegateBridge __Hotfix0_get_PropNeedCount;

	private static DelegateBridge __Hotfix0_set_PropNeedCount;

	private static DelegateBridge __Hotfix0_get_PropHaveCount;

	private static DelegateBridge __Hotfix0_get_IsEnough;

	private static DelegateBridge __Hotfix0_get_IsBreak;

	private static DelegateBridge __Hotfix0_get_Prop;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UseProp;

	private static DelegateBridge __Hotfix0_GetPropHaveCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int PropID { get; set; }

	private int PropType { get; set; }

	public int PropNeedCount { get; set; }

	public long PropHaveCount => 0L;

	public bool IsEnough => false;

	public bool IsBreak => false;

	public Drop_DropModel.DropData Prop => null;

	public static SkinAbilityMaterialItemData Create(int propID, int propType, int propNeedCount)
	{
		return null;
	}

	public void UseProp()
	{
	}

	private long GetPropHaveCount()
	{
		return 0L;
	}
}
