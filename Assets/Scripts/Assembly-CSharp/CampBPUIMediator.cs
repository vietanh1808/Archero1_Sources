using System.Collections.Generic;

public class CampBPUIMediator : MediatorBase
{
	public new const string NAME = "CampBPUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampBPUIMediator()
		: base(null)
	{
	}
}
