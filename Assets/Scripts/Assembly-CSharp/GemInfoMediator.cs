using System.Collections.Generic;

public class GemInfoMediator : MediatorBase
{
	public new const string NAME = "GemInfoMediator";

	public override List<string> OnListNotificationInterests => null;

	public GemInfoMediator()
		: base(null)
	{
	}
}
