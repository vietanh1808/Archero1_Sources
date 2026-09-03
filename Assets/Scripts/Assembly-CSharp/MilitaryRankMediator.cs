using System.Collections.Generic;

public class MilitaryRankMediator : MediatorBase
{
	public new const string NAME = "MilitaryRankMediator";

	public override List<string> OnListNotificationInterests => null;

	public MilitaryRankMediator()
		: base(null)
	{
	}
}
