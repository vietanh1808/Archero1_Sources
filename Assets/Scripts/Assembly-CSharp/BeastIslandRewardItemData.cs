using System.Collections.Generic;
using TableTool;

public class BeastIslandRewardItemData
{
	private BeastIslandAllRewardData parent;

	public int ID;

	public int NeedProgress;

	public List<Drop_DropModel.DropData> Rewards;

	public BeastIslandRewardStatus Status => BeastIslandRewardStatus.None;

	public BeastIslandRewardItemData(BeastIslandAllRewardData _parent, int id, int need, uint[][] m_vecRewards)
	{
	}
}
