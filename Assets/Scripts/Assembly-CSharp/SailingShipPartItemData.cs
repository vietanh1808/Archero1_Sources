using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SailingShipPartItemData
{
	private SailingShipPartItemSourceData SourceData { get; set; }

	public ShipBattle_Upgrade ConfigData => null;

	public int Round => 0;

	public int MaxRound => 0;

	public bool IsMonster => false;

	public int ConfigID => 0;

	public int PartID => 0;

	public int Level => 0;

	public int SkinID => 0;

	public int SlotID => 0;

	public List<SailingShipEffectData> EffectData => null;

	public SailingShipPartSkinItemData SkinData => null;

	public Sprite PartIcon => null;

	public Sprite PartShowIcon => null;

	public Sprite PartTabIcon => null;

	public List<SailingShipPartUpgradeMaterialItemData> MaterialItemData => null;

	public Dictionary<string, SailingShipPartAttributeItemData> Abilities => null;

	public Dictionary<string, SailingShipPartAttributeItemData> NextLevelAbilities => null;

	public (int, List<SailingShipPartAttributeItemData>) PreUnlockAtt => default;

	public int MaxLevel => 0;

	public string PartName => null;

	public string PartDesc => null;

	public Vector2 PosInShip => default;

	public bool IsUnlock => false;

	public Vector2 Pivot => default;

	public SailingShipPartPosType PosType => SailingShipPartPosType.None;

	public bool IsShowInBoat => false;

	public static SailingShipPartItemData Create(SailingShipPartItemSourceData sourceData)
	{
		return null;
	}

	private List<SailingShipPartUpgradeMaterialItemData> GetMaterialItemData()
	{
		return null;
	}

	private Dictionary<string, SailingShipPartAttributeItemData> GetAttributeItemData()
	{
		return null;
	}

	private Dictionary<string, SailingShipPartAttributeItemData> GetNextLevelAttributeItemData()
	{
		return null;
	}

	private (int, List<SailingShipPartAttributeItemData>) GetPreAtt()
	{
		return default;
	}

	private int GetMaxLevel()
	{
		return 0;
	}

	private int GetMaxRound()
	{
		return 0;
	}

	private SailingShipPartSkinItemData GetSkinData()
	{
		return null;
	}

	public List<SailingShipEffectData> GetEffectDatas()
	{
		return null;
	}

	public void SetSkinID(int id)
	{
	}

	public void SetLevel(int level)
	{
	}

	public void SetPos(Vector2 pos)
	{
	}

	public void SetPivot(Vector2 pivot)
	{
	}
}
