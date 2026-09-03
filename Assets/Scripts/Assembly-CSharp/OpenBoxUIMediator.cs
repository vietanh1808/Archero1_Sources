using System.Collections.Generic;

public class OpenBoxUIMediator : MediatorBase
{
	public new const string NAME = "OpenBoxUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public OpenBoxUIMediator()
		: base(null)
	{
	}
}
