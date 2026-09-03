using System.Collections.Generic;

public class HolyLightTaskMediator : MediatorBase
{
	public new const string NAME = "HolyLightTaskMediator";

	public override List<string> OnListNotificationInterests => null;

	public HolyLightTaskMediator()
		: base(null)
	{
	}
}
