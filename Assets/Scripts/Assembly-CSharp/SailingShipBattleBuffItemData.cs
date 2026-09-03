public class SailingShipBattleBuffItemData
{
	public string BuffKey { get; set; }

	public SailingShipBattleFighter Fighter { get; set; }

	public int SlotPos { get; set; }

	public int BuffID { get; set; }

	public SailingShipBattleBuffType BuffType { get; set; }

	public long StartTime { get; set; }

	public long TotalTime { get; set; }

	public long LeftTime { get; set; }

	public int PreviousLayer { get; set; }

	public int Layer { get; set; }

	public long CDTime { get; set; }

	public float RealLeftTime => 0f;

	public bool IsShown => false;

	public string IconString => null;

	public bool IsForeverBuff => false;

	public bool IsCDBuff => false;

	public long CDStartTime { get; set; }

	public float RealCDLeftTime => 0f;

	public static SailingShipBattleBuffItemData Create(string buffKey, SailingShipBattleFighter fighter, int slotPos, int buffID, SailingShipBattleBuffType buffType, long startTime, long totalTime, long leftTime, int layer, int previousLayer)
	{
		return null;
	}

	public static SailingShipBattleBuffItemData Create(string buffKey, SailingShipBattleFighter fighter, int slotPos, int buffID, SailingShipBattleBuffType buffType, long startTime, long totalTime, long leftTime, int layer, int previousLayer, long cdTime, long cdStartTime)
	{
		return null;
	}

	private float GetRealLeftTime()
	{
		return 0f;
	}
}
