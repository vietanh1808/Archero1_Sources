using System.Collections.Generic;

public class UnderseaRuinMediator : MediatorBase
{
	public new const string NAME = "DSMShootMediator";

	public override List<string> OnListNotificationInterests => null;

	public UnderseaRuinMediator()
		: base(null)
	{
	}
}
