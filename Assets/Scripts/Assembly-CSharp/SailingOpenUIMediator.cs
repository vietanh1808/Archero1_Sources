using System.Collections.Generic;

public class SailingOpenUIMediator : MediatorBase
{
	public new const string NAME = "SailingMainUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingOpenUIMediator()
		: base(null)
	{
	}
}
