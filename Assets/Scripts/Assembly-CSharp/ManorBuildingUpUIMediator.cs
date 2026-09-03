using System.Collections.Generic;

public class ManorBuildingUpUIMediator : MediatorBase
{
	public new const string NAME = "ManorBuildingUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorBuildingUpUIMediator()
		: base(null)
	{
	}
}
