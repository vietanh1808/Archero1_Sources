using System.Collections.Generic;

public class SailingShipEntityItemData
{
	public SailingShipEntityType EntityType { get; set; }

	public SailingShipBattleFighter Fighter { get; set; }

	public List<SailingShipEntityPartData> AllPart { get; set; }

	public SailingShipEntityAttributeData Attribute { get; set; }

	public SailingShipBattleBuffData BuffData { get; set; }

	public bool IsPlayer => false;

	public List<SailingShipEntityPartData> AllActivePart => null;

	public List<SailingShipEntityPartData> AllVisualPart => null;

	public List<SailingShipEntityPartData> AllVisualAndActivePart => null;

	public SailingShipEntityPartData ShipPartData => null;

	public static SailingShipEntityItemData Create(SailingShipEntityType entityType, SailingShipBattleFighter fighter, List<SailingShipEntityPartData> allPart)
	{
		return null;
	}

	public SailingShipEntityPartData GetPartData(int slotPos)
	{
		return null;
	}

	public void UpdateAttr(SailingShipBattleAttributeItemData attrData)
	{
	}

	public void UpdateSelfBuff(List<SailingShipBattleBuffItemData> wholeShipBuff)
	{
	}

	public void RemoveSelfBuff(List<string> removeBuffData)
	{
	}

	public void UpdateBuff(List<SailingShipBattleBuffItemData> buffItemData)
	{
	}

	public void RemoveBuff(List<string> removeBuffData)
	{
	}
}
