using System;
using System.Collections.Generic;

[Serializable]
public class EquipStorageBaseData
{
	public Dictionary<int, EquipStorageItemBaseData> EData;

	public static EquipStorageBaseData Create(Dictionary<int, EquipStorageItemBaseData> eData)
	{
		return null;
	}

	public void SetPageEquipIDByIndex(int page, int index, int equipID)
	{
	}
}
