public class CampKingScrambleBaseData : RecycleData<CampKingScrambleBaseSourceData>
{
	public (int, int) Position => default;

	public CampKingScrambleStatus Status => CampKingScrambleStatus.None;

	public CampKingScrambleRewardStatus RewardStatus => CampKingScrambleRewardStatus.None;

	public long StatusLeftTime(CampKingScrambleStatus curStatus)
	{
		return 0L;
	}

	private long GetStatusLeftTime(CampKingScrambleStatus curStatus)
	{
		return 0L;
	}

	private CampKingScrambleRewardStatus GetRewardStatus()
	{
		return CampKingScrambleRewardStatus.None;
	}
}
