using System.Collections.Generic;

public class DropUpActivityMediator : MediatorBase
{
	public new const string NAME = "DropUpActivityMediator";

	public override List<string> OnListNotificationInterests => null;

	public DropUpActivityMediator()
		: base(null)
	{
	}
}
