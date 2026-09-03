using System.Collections.Generic;

public class SailingPreUIMediator : MediatorBase
{
	public new const string NAME = "SailingPreUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingPreUIMediator()
		: base(null)
	{
	}
}
