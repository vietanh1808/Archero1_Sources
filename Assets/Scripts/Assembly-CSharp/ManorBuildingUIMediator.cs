using System.Collections.Generic;

public class ManorBuildingUIMediator : MediatorBase
{
	public new const string NAME = "ManorBuildingUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorBuildingUIMediator()
		: base(null)
	{
	}
}
