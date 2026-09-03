using System.Collections.Generic;

public class CampBoxUIMediator : MediatorBase
{
	public new const string NAME = "CampBoxUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampBoxUIMediator()
		: base(null)
	{
	}
}
