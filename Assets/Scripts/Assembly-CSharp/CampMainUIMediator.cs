using System.Collections.Generic;

public class CampMainUIMediator : MediatorBase
{
	public new const string NAME = "CampMainUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampMainUIMediator()
		: base(null)
	{
	}
}
