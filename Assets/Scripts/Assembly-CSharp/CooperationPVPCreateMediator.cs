using System.Collections.Generic;

public class CooperationPVPCreateMediator : MediatorBase
{
	public new const string NAME = "CooperationPVPCreateMediator";

	public override List<string> OnListNotificationInterests => null;

	public CooperationPVPCreateMediator()
		: base(null)
	{
	}
}
