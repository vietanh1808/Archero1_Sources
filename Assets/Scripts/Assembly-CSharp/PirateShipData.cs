using System.Collections.Generic;

public class PirateShipData : RecycleData<PirateShipConfigData>
{
	public int Tag => 0;

	public bool IsOpen => false;

	public bool IsReachOpenTime => false;

	public long LeftTime => 0L;

	public List<PirateShipItemData> ItemData => null;

	public long EndTime => 0L;

	private List<PirateShipItemData> GetItemData()
	{
		return null;
	}
}
