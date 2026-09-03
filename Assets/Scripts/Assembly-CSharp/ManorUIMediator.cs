using System.Collections.Generic;

public class ManorUIMediator : MediatorBase
{
	public new const string NAME = "ManorUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorUIMediator()
		: base(null)
	{
	}
}
