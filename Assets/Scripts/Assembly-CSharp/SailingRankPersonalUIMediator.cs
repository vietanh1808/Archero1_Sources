using System.Collections.Generic;

public class SailingRankPersonalUIMediator : MediatorBase
{
	public new const string NAME = "SailingRankPersonalUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingRankPersonalUIMediator()
		: base(null)
	{
	}
}
