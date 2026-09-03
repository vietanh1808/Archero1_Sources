using System.Collections.Generic;

public class CampSelfBuffUIMediator : MediatorBase
{
	public new const string NAME = "CampSelfBuffUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampSelfBuffUIMediator()
		: base(null)
	{
	}
}
