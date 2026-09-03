using System.Collections.Generic;

public class SailingShipPartSkinData : RecycleData<SailingShipPartSkinSourceData>
{
	public Dictionary<int, List<SailingShipPartSkinItemData>> SkinMap => null;

	public List<SailingShipPartSkinItemData> AllSkin => null;

	public List<SailingShipPartSkinItemData> UnlockSkin => null;

	private Dictionary<int, List<SailingShipPartSkinItemData>> GetShipSkinMapData()
	{
		return null;
	}

	public List<SailingShipPartSkinItemData> GetPartSkinDataByPartID(int partID)
	{
		return null;
	}

	public List<SailingShipPartSkinItemData> GetPartLockSkinDataByPartID(int partID)
	{
		return null;
	}

	private List<SailingShipPartSkinItemData> GetUnlockSkin()
	{
		return null;
	}

	public void AddSkinData(SailingShipPartSkinItemSourceData sData)
	{
	}
}
