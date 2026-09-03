using System.Collections.Generic;

public class SweepStartMediator : MediatorBase
{
	public new const string NAME = "SweepStartMediator";

	public override List<string> OnListNotificationInterests => null;

	public SweepStartMediator()
		: base(null)
	{
	}
}
