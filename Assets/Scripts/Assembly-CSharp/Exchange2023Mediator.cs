using System.Collections.Generic;

public class Exchange2023Mediator : MediatorBase
{
	public new const string NAME = "Exchange2023Mediator";

	public override List<string> OnListNotificationInterests => null;

	public Exchange2023Mediator()
		: base(null)
	{
	}
}
