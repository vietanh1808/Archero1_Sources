using TableTool;

public class SailingGhostFleetShipItemData
{
	private SailingGhostFleetShipItemSourceData ConfigData { get; set; }

	public int ID => 0;

	public ShipStage_ShipDifficulty Config => null;

	public bool IsHaveUnLockCond => false;

	public SailingGhostFleetAttributeData AttributeData => null;

	public SailingGhostFleetShipBgType BgType => SailingGhostFleetShipBgType.None;

	public bool IsNeedTipSpecial => false;

	public SailingShipType ShipType => SailingShipType.None;

	public static SailingGhostFleetShipItemData Create(SailingGhostFleetShipItemSourceData sourceData)
	{
		return null;
	}
}
