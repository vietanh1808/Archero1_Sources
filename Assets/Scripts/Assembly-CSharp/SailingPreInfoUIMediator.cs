using System.Collections.Generic;

public class SailingPreInfoUIMediator : MediatorBase
{
	public new const string NAME = "SailingPreInfoUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingPreInfoUIMediator()
		: base(null)
	{
	}
}
