using System.Collections.Generic;

public class FarmRankMediator : MediatorBase
{
	public new const string NAME = "FarmRankMediator";

	public override List<string> OnListNotificationInterests => null;

	public FarmRankMediator()
		: base(null)
	{
	}
}
