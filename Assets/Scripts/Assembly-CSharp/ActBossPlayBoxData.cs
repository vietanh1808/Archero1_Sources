public class ActBossPlayBoxData : ViewCellData
{
	public enum RewardStatus
	{
		None = 0,
		UnComplete = 1,
		Complete = 2,
		Claimed = 3
	}

	public BossPlayBoxItemData data;

	public bool isGet => false;

	public RewardStatus Status => RewardStatus.None;
}
