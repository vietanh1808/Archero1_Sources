using System;

[Serializable]
public class TimeMachineStats
{
	public TimeMachineLoginStat login;

	public TimeMachineMonsterStat monster;

	public TimeMachineHeroStat hero;

	public TimeMachinePveStat pve;

	public TimeMachineSummary summary;
}
