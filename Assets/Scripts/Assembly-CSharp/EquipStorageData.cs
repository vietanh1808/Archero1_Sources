using System.Collections.Generic;

public class EquipStorageData : RecycleData<EquipStorageBaseData>
{
	public Dictionary<int, EquipStorageItemData> StorageMap => null;

	public Dictionary<int, EquipStorageItemData> GetEquipStorageData()
	{
		return null;
	}

	public void SetPageEquipIDByIndex(int page, int index, int equipID)
	{
	}
}
