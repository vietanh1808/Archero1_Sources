using System.Collections.Generic;

public class SailingShipBattleBuffData
{
	public Dictionary<string, SailingShipBattleBuffItemData> BuffItemData;

	public static SailingShipBattleBuffData Create(Dictionary<string, SailingShipBattleBuffItemData> buffItemData)
	{
		return null;
	}

	public void UpdateBuff(List<SailingShipBattleBuffItemData> buffItemData)
	{
	}

	public bool RemoveBuff(List<string> removeBuffData)
	{
		return false;
	}
}
