using System.Collections.Generic;

public class ManorStealInsUIMediator : MediatorBase
{
	public new const string NAME = "ManorStealInsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorStealInsUIMediator()
		: base(null)
	{
	}
}
