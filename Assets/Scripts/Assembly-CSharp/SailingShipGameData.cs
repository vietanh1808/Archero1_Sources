using System.Collections.Generic;

public class SailingShipGameData
{
	public SailingShipBattleRequestType BattleType { get; set; }

	public long BattleTotalTime { get; set; }

	public long BattleLeftTime { get; set; }

	public long BattleLastTime { get; set; }

	public int BattleAttrUnit { get; set; }

	public Dictionary<string, long> RecordData { get; set; }

	public float BattleRunTime { get; set; }

	private SailingShipEntityData ShipEntityData { get; set; }

	private SailingShipBattleMsgData BattleMsgData { get; set; }

	private SailingShipWarningData WarningData { get; set; }

	private SailingShipBattleResultData BattleResultData { get; set; }

	public bool IsBattleBoss => false;

	public static SailingShipGameData Create(SailingShipBattleRequestType battleType, long battleTotalTime, long battleLastTime, int battleAttrUnit, Dictionary<string, long> recordData, SailingShipEntityData shipEntityData, SailingShipBattleMsgData battleMsgData, SailingShipWarningData warningData, SailingShipBattleResultData battleResultData)
	{
		return null;
	}

	public bool OnUpdate(float deltaTime)
	{
		return false;
	}

	public void SetLeftTime(int leftTime)
	{
	}

	public SailingShipEntityData GetShipEntityData()
	{
		return null;
	}

	public SailingShipBattleMsgData GetBattleMsgData()
	{
		return null;
	}

	public SailingShipWarningData GetWarningData()
	{
		return null;
	}

	public SailingShipBattleResultData GetSailingShipBattleResultData()
	{
		return null;
	}
}
