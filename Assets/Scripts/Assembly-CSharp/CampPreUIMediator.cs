using System.Collections.Generic;

public class CampPreUIMediator : MediatorBase
{
	public new const string NAME = "CampPreUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampPreUIMediator()
		: base(null)
	{
	}
}
