public class SailingShipWarningItemData
{
	public SailingShipBattleFighter Fighter { get; set; }

	public SailingShipEntityType EntityType { get; set; }

	public int BattlePower { get; set; }

	public ulong RawID { get; set; }

	public string Name { get; set; }

	public int HeadID { get; set; }

	public int HeadFrame { get; set; }

	public long HeadFrameTime { get; set; }

	public int VipLevel { get; set; }

	public bool IsPlayer => false;

	public string PlayerName => null;

	public static SailingShipWarningItemData Create(SailingShipBattleFighter fighter, SailingShipEntityType entityType, string name, int battlePower, ulong rawID, int headID, int headFrame, long headFrameTime, int vipLevel)
	{
		return null;
	}
}
