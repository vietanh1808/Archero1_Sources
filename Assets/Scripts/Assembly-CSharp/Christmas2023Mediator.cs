using System.Collections.Generic;

public class Christmas2023Mediator : MediatorBase
{
	public new const string NAME = "Christmas2023Mediator";

	public override List<string> OnListNotificationInterests => null;

	public Christmas2023Mediator()
		: base(null)
	{
	}
}
