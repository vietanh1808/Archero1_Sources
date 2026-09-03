using System.Collections.Generic;

public class SantaClausMediator : MediatorBase
{
	public new const string NAME = "SantaClausMediator";

	public override List<string> OnListNotificationInterests => null;

	public SantaClausMediator()
		: base(null)
	{
	}
}
