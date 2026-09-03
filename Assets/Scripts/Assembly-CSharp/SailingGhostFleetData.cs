public class SailingGhostFleetData : RecycleData<SailingGhostFleetSourceData>
{
	public long StartTime => 0L;

	public long EndTime => 0L;

	public long RankingEndTime => 0L;

	public bool IsUnStart => false;

	public bool IsEnd => false;

	public bool IsOpen => false;

	public bool IsRankingOpen => false;

	public long LeftTime => 0L;

	public int HaveBattleCount => 0;

	public int FreeRefreshLeftCount => 0;

	public int CostRefreshHaveCount => 0;

	public SailingGhostFleetShipData ShipData => null;

	public int CostStaminaCount => 0;

	public int CostDiamondCount => 0;

	public int ChallengeLimit => 0;

	public SailingGhostFleetRankingData RankingData => null;

	private int GetCostStaminaCount()
	{
		return 0;
	}

	private int GetCostDiamondCount()
	{
		return 0;
	}
}
