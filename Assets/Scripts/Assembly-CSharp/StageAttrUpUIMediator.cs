using System.Collections.Generic;

public class StageAttrUpUIMediator : MediatorBase
{
	public new const string NAME = "StageAttrUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public StageAttrUpUIMediator()
		: base(null)
	{
	}
}
