using System.Collections.Generic;

public class CooperationCreateMediator : MediatorBase
{
	public new const string NAME = "CooperationCreateMediator";

	public override List<string> OnListNotificationInterests => null;

	public CooperationCreateMediator()
		: base(null)
	{
	}
}
