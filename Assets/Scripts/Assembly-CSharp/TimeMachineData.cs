public class TimeMachineData
{
	public int ErrorCode;

	public long beginTime;

	private TimeMachineStatData statData;

	public TimeMachineStatData StatData => null;

	public bool IsValid => false;

	public TimeMachineLoginStat Login => null;

	public TimeMachineMonsterStat Monster => null;

	public TimeMachineHeroStat Hero => null;

	public TimeMachinePveStat Pve => null;

	public TimeMachineSummary Summary => null;

	public TimeMachineReward Reward => null;

	public void Parse(string json)
	{
	}

	public int GetLabelQuality(string source)
	{
		return 0;
	}
}
