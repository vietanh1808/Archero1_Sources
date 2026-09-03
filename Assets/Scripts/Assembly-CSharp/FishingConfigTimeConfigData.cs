using System;

[Serializable]
public class FishingConfigTimeConfigData
{
	public int Tag;

	public int Version;

	public long OpenTime;

	public long FishEndTime;

	public long RewardEndTime;

	public long EndTime;

	public int OpenGameLevel;

	public int[] Layer;
}
