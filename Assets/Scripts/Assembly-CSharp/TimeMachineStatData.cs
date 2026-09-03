using System;

[Serializable]
public class TimeMachineStatData
{
	public int tag;

	public int last_refresh_day;

	public long last_refresh_time;

	public int favorite_hero_id;

	public TimeMachineReward reward;

	public TimeMachineStats stats;
}
