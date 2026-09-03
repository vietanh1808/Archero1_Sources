using System.Collections.Generic;

public class MenuPopMediator : MediatorBase
{
	public new const string NAME = "MenuPopMediator";

	public override List<string> OnListNotificationInterests => null;

	public MenuPopMediator()
		: base(null)
	{
	}
}
