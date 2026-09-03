using System.Collections.Generic;

public class ChristmasConfig
{
	public Dictionary<string, ChristmasEventData> open;

	public ChristmasWishingReward[] wishing_reward;

	public Dictionary<string, ChristmasActiveTask> active_task;

	public Dictionary<string, ChristmasDailyTask> daily_task;

	public Dictionary<string, ChristmasServerReward> allservice_reward;

	public Dictionary<string, ChristmasSignRewards> Signin_Rewards;

	public Dictionary<string, ChristmasGift> Christmas_Gift;
}
