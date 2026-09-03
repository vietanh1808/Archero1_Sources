using System.Collections.Generic;

public class MonopolyRankUIMediator : MediatorBase
{
	public new const string NAME = "MonopolyRankUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyRankUIMediator()
		: base(null)
	{
	}
}
