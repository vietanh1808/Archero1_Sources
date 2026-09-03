using System.Collections.Generic;

public class HolyLightMediator : MediatorBase
{
	public new const string NAME = "HolyLightMediator";

	public override List<string> OnListNotificationInterests => null;

	public HolyLightMediator()
		: base(null)
	{
	}
}
