using System.Collections.Generic;

public class CampTownUpUIMediator : MediatorBase
{
	public new const string NAME = "CampTownUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTownUpUIMediator()
		: base(null)
	{
	}
}
