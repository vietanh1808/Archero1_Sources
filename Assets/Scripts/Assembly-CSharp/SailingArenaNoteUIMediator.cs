using System.Collections.Generic;

public class SailingArenaNoteUIMediator : MediatorBase
{
	public new const string NAME = "SailingArenaNoteUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingArenaNoteUIMediator()
		: base(null)
	{
	}
}
