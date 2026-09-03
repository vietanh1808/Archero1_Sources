using TableTool;

public class SailingShipPartUpgradeMaterialItemData
{
	private int PropID { get; set; }

	private int PropType { get; set; }

	public int MaterialType { get; set; }

	public int PropNeedCount { get; set; }

	public long PropHaveCount => 0L;

	public bool IsEnough => false;

	public Drop_DropModel.DropData NeedProp => null;

	public static SailingShipPartUpgradeMaterialItemData Create(int propID, int propType, int propNeedCount, int materialType)
	{
		return null;
	}

	private long GetPropHaveCount()
	{
		return 0L;
	}
}
