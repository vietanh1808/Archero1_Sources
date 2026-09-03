using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SailingShipPartSkinItemData
{
	private SailingShipPartSkinItemSourceData SourceData { get; set; }

	public ShipBattle_ShipSkin Config => null;

	public ShipBattle_ShipSkinPart SkinPartConfig => null;

	public int PartID => 0;

	public int SkinID => 0;

	public bool IsHave => false;

	public bool IsMonster => false;

	public List<SailingShipEffectData> EffectData => null;

	public SailingShipPartItemData PartData => null;

	public Sprite SkinPartIcon => null;

	public Sprite IconInBoat => null;

	public int Power => 0;

	public string SkinName => null;

	public string SkinDesc => null;

	public Dictionary<string, SailingShipPartAttributeItemData> Abilities => null;

	public Dictionary<string, SailingShipPartAttributeItemData> NextLevelAbilities => null;

	public Dictionary<string, SailingShipPartAttributeItemData> OnlySkinAbilities => null;

	public bool IsNew => false;

	public bool IsDisplay => false;

	public static SailingShipPartSkinItemData Create(SailingShipPartSkinItemSourceData sourceData)
	{
		return null;
	}

	private ShipBattle_ShipSkinPart GetPartConfig()
	{
		return null;
	}

	private ShipBattle_ShipSkinPart GetNextLevelPartConfig()
	{
		return null;
	}

	private Dictionary<string, SailingShipPartAttributeItemData> GetSkinPartAttData(bool isNextLevel)
	{
		return null;
	}

	private Dictionary<string, SailingShipPartAttributeItemData> GetOnlySkinPartAttData()
	{
		return null;
	}

	private List<SailingShipEffectData> GetEffectData()
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
