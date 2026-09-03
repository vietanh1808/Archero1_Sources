using System.Collections.Generic;

public class ManorCardUIMediator : MediatorBase
{
	public new const string NAME = "ManorCardUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorCardUIMediator()
		: base(null)
	{
	}
}
