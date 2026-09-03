using System.Collections.Generic;

public class CooperationCreateTipsUIMediator : MediatorBase
{
	public new const string NAME = "CooperationCreateTipsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CooperationCreateTipsUIMediator()
		: base(null)
	{
	}
}
