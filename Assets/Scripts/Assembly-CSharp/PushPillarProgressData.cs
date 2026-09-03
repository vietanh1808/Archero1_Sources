using System.Collections.Generic;
using TableTool;

public class PushPillarProgressData : ViewCellData
{
	public enum RewardStatus
	{
		UnComplete = 0,
		Complete = 1,
		Claimed = 2
	}

	public int ID;

	public long NeedProgress;

	public List<Drop_DropModel.DropData> rewards;

	public RewardStatus Status => RewardStatus.UnComplete;
}
