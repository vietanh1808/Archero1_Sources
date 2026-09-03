using System.Collections.Generic;

public class SailingShipBattleMsgData
{
	public Queue<SailingShipBattleMsgItemData> BattleMsgItemData { get; set; }

	public bool CanPlayBattleMsg => false;

	public SailingShipBattleMsgItemData LastBattleMsg => null;

	public static SailingShipBattleMsgData Create(Queue<SailingShipBattleMsgItemData> battleMsgItemData)
	{
		return null;
	}

	public bool IsNeedPlayBattleMsg(float curTime)
	{
		return false;
	}

	public SailingShipBattleMsgItemData GetPlayBattleMsg()
	{
		return null;
	}
}
