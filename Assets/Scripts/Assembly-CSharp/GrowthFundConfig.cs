using System;

[Serializable]
public class GrowthFundConfig
{
	public int id;

	public int open;

	public string desc;

	public int MinLevel;

	public int MaxLevel;

	public int version;

	public GrowthFundRewardConfig[] reward;
}
