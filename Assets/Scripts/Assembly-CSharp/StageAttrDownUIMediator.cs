using System.Collections.Generic;

public class StageAttrDownUIMediator : MediatorBase
{
	public new const string NAME = "StageAttrDownUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public StageAttrDownUIMediator()
		: base(null)
	{
	}
}
