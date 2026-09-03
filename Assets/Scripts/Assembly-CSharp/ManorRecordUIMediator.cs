using System.Collections.Generic;

public class ManorRecordUIMediator : MediatorBase
{
	public new const string NAME = "ManorRecordUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorRecordUIMediator()
		: base(null)
	{
	}
}
