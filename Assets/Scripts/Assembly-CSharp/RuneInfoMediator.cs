using System.Collections.Generic;

public class RuneInfoMediator : MediatorBase
{
	public new const string NAME = "RuneInfoMediator";

	public override List<string> OnListNotificationInterests => null;

	public RuneInfoMediator()
		: base(null)
	{
	}
}
