using System.Collections.Generic;

public class CampRankUIMediator : MediatorBase
{
	public new const string NAME = "CampRankUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampRankUIMediator()
		: base(null)
	{
	}
}
