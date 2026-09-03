using System.Collections.Generic;
using TableTool;

public class TradingAchRewardItemData
{
	public int ID;

	public int NeedProgress;

	public int NeedAllProgress;

	public bool isGetReward;

	public int index;

	public bool isSpecialShow;

	public bool isLast;

	public int ItemType;

	public List<Drop_DropModel.DropData> Rewards;

	public virtual bool isLoop => false;

	public virtual TradingAchievementRewardStatus Status => TradingAchievementRewardStatus.None;

	public virtual int Left => 0;

	public virtual float Rate => 0f;
}
