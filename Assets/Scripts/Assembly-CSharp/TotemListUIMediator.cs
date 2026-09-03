using System.Collections.Generic;

public class TotemListUIMediator : MediatorBase
{
	public new const string NAME = "TotemListUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public TotemListUIMediator()
		: base(null)
	{
	}
}
