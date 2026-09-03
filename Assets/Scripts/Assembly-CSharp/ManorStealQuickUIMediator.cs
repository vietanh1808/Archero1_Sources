using System.Collections.Generic;

public class ManorStealQuickUIMediator : MediatorBase
{
	public new const string NAME = "ManorStealQuickUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorStealQuickUIMediator()
		: base(null)
	{
	}
}
