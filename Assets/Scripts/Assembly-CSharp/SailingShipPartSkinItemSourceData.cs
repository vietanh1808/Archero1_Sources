public class SailingShipPartSkinItemSourceData
{
	public int SkinID;

	public int PartID;

	public SailingShipPartItemData PartData;

	public bool IsMonster;

	public bool IsNew;

	public static SailingShipPartSkinItemSourceData Create(int skinID, int partID, SailingShipPartItemData partData, bool isMonster = false, bool isNew = false)
	{
		return null;
	}

	public void RefreshPartData(SailingShipPartItemData partData)
	{
	}

	public void SetIsNew(bool status)
	{
	}
}
