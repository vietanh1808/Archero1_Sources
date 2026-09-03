using System.Collections.Generic;

public class SailingPreSignUIMediator : MediatorBase
{
	public new const string NAME = "SailingPreSignUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingPreSignUIMediator()
		: base(null)
	{
	}
}
