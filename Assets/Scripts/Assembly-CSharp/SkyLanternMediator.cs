using System.Collections.Generic;

public class SkyLanternMediator : MediatorBase
{
	public new const string NAME = "SkyLanternMediator";

	public override List<string> OnListNotificationInterests => null;

	public SkyLanternMediator()
		: base(null)
	{
	}
}
