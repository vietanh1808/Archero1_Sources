using System.Collections.Generic;

public class SailingShipPartData : RecycleData<SailingShipPartSourceData>
{
	public List<SailingShipPartItemData> ItemData => null;

	public List<SailingShipPartItemData> ItemTabData => null;

	public SailingShipPartItemData GetItemDataByPartID(int partID)
	{
		return null;
	}

	public SailingShipPartItemData GetItemDataByPartIDAndPosType(int partID, SailingShipPartPosType posType)
	{
		return null;
	}

	public SailingShipPartItemData GetItemDataBySlotID(int slotID)
	{
		return null;
	}

	public List<SailingShipPartItemData> GetAllItemDataByPartID(int partID)
	{
		return null;
	}

	public Dictionary<string, float> GetAllAttMap()
	{
		return null;
	}

	public int GetAllPower()
	{
		return 0;
	}
}
