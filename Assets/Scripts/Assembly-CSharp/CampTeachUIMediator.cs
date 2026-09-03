using System.Collections.Generic;

public class CampTeachUIMediator : MediatorBase
{
	public new const string NAME = "CampTeachUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTeachUIMediator()
		: base(null)
	{
	}
}
