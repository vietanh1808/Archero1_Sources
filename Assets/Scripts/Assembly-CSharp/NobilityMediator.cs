using System.Collections.Generic;

public class NobilityMediator : MediatorBase
{
	public new const string NAME = "NobilityMediator";

	public override List<string> OnListNotificationInterests => null;

	public NobilityMediator()
		: base(null)
	{
	}
}
