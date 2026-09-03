using Newtonsoft.Json;

public class DailyPlay129ActData
{
	public int tag;

	public int level;

	public long startTime;

	public long endTime;

	public int diftId;

	public int maxDiftId;

	public int score;

	public int boxFlag;

	public int boxCountExtra;

	[JsonIgnore]
	public int diftLevel => 0;

	[JsonIgnore]
	public int diftMaxLevel => 0;
}
