using System.Collections.Generic;

public class ManorRepairUIMediator : MediatorBase
{
	public new const string NAME = "ManorRepairUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorRepairUIMediator()
		: base(null)
	{
	}
}
