using System.Collections.Generic;
using TableTool;

public class SailingShipEntityPartData
{
	public int ID { get; set; }

	public int SlotPos { get; set; }

	public int Level { get; set; }

	public int SkinID { get; set; }

	public SailingShipBattleFighter Fighter { get; set; }

	public SailingShipEntityType EntityType { get; set; }

	public SailingShipPartPosType PosType { get; set; }

	public SailingShipEntityPart EntityPart { get; set; }

	public SailingShipEntityStatus Status { get; set; }

	public SailingShipEntityAttributeData Attribute { get; set; }

	public SailingShipBattleBuffData BuffData { get; set; }

	public bool IsShowCircleStatus => false;

	public bool IsPlayerPart => false;

	public bool IsActivePart => false;

	public bool IsVisual => false;

	public bool IsShown => false;

	public SailingShipPartType Type => SailingShipPartType.None;

	public SailingShipEntityStatus AllowStatus => SailingShipEntityStatus.None;

	public static SailingShipEntityPartData Create(int id, int slotPos, int level, int skinID, SailingShipBattleFighter fighter, SailingShipEntityType entityType, SailingShipPartPosType posType)
	{
		return null;
	}

	public void UpdateStatus()
	{
	}

	public void UpdateAttr(Goods_goods.GoodData data)
	{
	}

	public void UpdateBuff(List<SailingShipBattleBuffItemData> buffItemData)
	{
	}

	public void RemoveBuff(List<string> removeBuffData)
	{
	}

	public void SetPartBase(SailingShipEntityPart partBase)
	{
	}

	public bool IsInStatus(SailingShipEntityStatus status)
	{
		return false;
	}

	public void SetStatus(SailingShipEntityStatus status)
	{
	}

	public void AddStatus(SailingShipEntityStatus status)
	{
	}

	public void RemoveStatus(SailingShipEntityStatus status)
	{
	}

	public bool IsAllowStatus(SailingShipEntityStatus status)
	{
		return false;
	}
}
