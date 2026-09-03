using System.Collections.Generic;

public class EquipStorageItemData
{
	private EquipStorageItemBaseData BaseData { get; set; }

	public int SkinID => 0;

	public int RoleID => 0;

	public int WeaponSkinID => 0;

	public List<int> AssistRoleIDs => null;

	public List<int> EquipIDs => null;

	public int ColorID => 0;

	public int WingID => 0;

	public List<int> WingAssistID => null;

	public int WingShowID => 0;

	public List<int> artifacts => null;

	public List<int> imprints => null;

	public List<int> dragons => null;

	public Dictionary<int, long> totems => null;

	public Dictionary<int, int[]> Carvings => null;

	public static EquipStorageItemData Create(EquipStorageItemBaseData baseData)
	{
		return null;
	}

	public bool IsDefaultData()
	{
		return false;
	}

	public void SetEquipIDByIndex(int index, int equipID)
	{
	}
}
