using System.Collections.Generic;

public class EquipStorageItemBaseData
{
	public int SkinID;

	public int RoleID;

	public int WeaponSkinID;

	public List<int> AssistRoleIDs;

	public List<int> EquipIDs;

	public int ColorID;

	public int WingID;

	public List<int> WingAssistID;

	public int WingShowID;

	public List<int> artifacts;

	public List<int> imprints;

	public List<int> dragons;

	public Dictionary<int, long> totems;

	public Dictionary<int, int[]> Carvings;

	public void SetEquipByIndex(int index, int equipID)
	{
	}
}
