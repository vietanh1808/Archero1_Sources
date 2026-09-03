using System.Collections.Generic;

public class RelicsElevateMediator : MediatorBase
{
	public new const string NAME = "RelicsElevateMediator";

	public override List<string> OnListNotificationInterests => null;

	public RelicsElevateMediator()
		: base(null)
	{
	}
}
