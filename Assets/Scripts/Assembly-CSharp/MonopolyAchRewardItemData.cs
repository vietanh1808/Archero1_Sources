using System.Collections.Generic;
using TableTool;

public class MonopolyAchRewardItemData
{
	public int ID;

	public int NeedProgress;

	public int NeedAllProgress;

	public bool isGetReward;

	public int index;

	public bool isLast;

	public int ItemType;

	public List<Drop_DropModel.DropData> Rewards;

	public virtual bool isLoop => false;

	public virtual Act5thTorchRewardStatus Status => Act5thTorchRewardStatus.None;

	public virtual int Left => 0;

	public virtual float Rate => 0f;
}
