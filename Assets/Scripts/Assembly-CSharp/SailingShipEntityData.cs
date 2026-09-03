using System.Collections.Generic;

public class SailingShipEntityData
{
	public List<SailingShipEntityItemData> EntityItemData { get; set; }

	public SailingShipEntityItemData SelfData => null;

	public SailingShipEntityItemData EnemyData => null;

	public bool IsUnlockSpeedUp => false;

	public float SpeedUpValue => 0f;

	public static SailingShipEntityData Create(List<SailingShipEntityItemData> entityItemData)
	{
		return null;
	}

	public SailingShipEntityItemData GetEntityItemData(SailingShipBattleFighter target)
	{
		return null;
	}

	public void UpdateAttr(SailingShipBattleAttributeData attributeData)
	{
	}

	public void UpdateBuff(SailingShipBattleBuffData buffData)
	{
	}

	public void RemoveBuff(List<string> removeBuffData)
	{
	}
}
