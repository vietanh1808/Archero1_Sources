using System.Collections.Generic;

public class ImprintMediator : MediatorBase
{
	public new const string NAME = "ImprintMediator";

	public override List<string> OnListNotificationInterests => null;

	public ImprintMediator()
		: base(null)
	{
	}
}
