using System.Collections.Generic;

public class SailingMapRankUIMediator : MediatorBase
{
	public new const string NAME = "SailingMapRankUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingMapRankUIMediator()
		: base(null)
	{
	}
}
