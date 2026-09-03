using System.Collections.Generic;

public class MonopolyRankRewardUIMediator : MediatorBase
{
	public new const string NAME = "MonopolyRankRewardUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyRankRewardUIMediator()
		: base(null)
	{
	}
}
