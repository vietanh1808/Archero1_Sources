using System.Collections.Generic;

public class TotemResolveUIMediator : MediatorBase
{
	public new const string NAME = "TotemResolveUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public TotemResolveUIMediator()
		: base(null)
	{
	}
}
