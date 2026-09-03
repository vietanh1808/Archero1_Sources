using System.Collections.Generic;

public class CampPreCallUIMediator : MediatorBase
{
	public new const string NAME = "CampPreCallUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampPreCallUIMediator()
		: base(null)
	{
	}
}
