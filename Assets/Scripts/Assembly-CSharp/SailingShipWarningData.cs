using System.Collections.Generic;

public class SailingShipWarningData
{
	public List<SailingShipWarningItemData> WarningItemData { get; set; }

	public SailingShipWarningItemData SelfData => null;

	public SailingShipWarningItemData EnemyData => null;

	public static SailingShipWarningData Create(List<SailingShipWarningItemData> WarningItemData)
	{
		return null;
	}
}
