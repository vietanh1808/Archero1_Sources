using System.Collections.Generic;

public class ActivityLatticeMediator : MediatorBase
{
	public new const string NAME = "ActivityLatticeMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActivityLatticeMediator()
		: base(null)
	{
	}
}
