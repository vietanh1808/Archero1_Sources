using System.Collections.Generic;

public class PurchaseConfig
{
	public Dictionary<string, PurchaseEventData> open;

	public PurchaseWishingReward[] wishing_reward;

	public Dictionary<string, PurchaseDailyTask> daily_task;

	public Dictionary<string, PurchaseGift> wish_gift;
}
