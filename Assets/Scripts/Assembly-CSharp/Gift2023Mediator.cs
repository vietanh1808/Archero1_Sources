using System.Collections.Generic;

public class Gift2023Mediator : MediatorBase
{
	public new const string NAME = "Gift2023Mediator";

	public override List<string> OnListNotificationInterests => null;

	public Gift2023Mediator()
		: base(null)
	{
	}
}
