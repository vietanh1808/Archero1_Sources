using System.Collections.Generic;

public class FarmCleanAllMediator : MediatorBase
{
	public new const string NAME = "FarmCleanAllMediator";

	public override List<string> OnListNotificationInterests => null;

	public FarmCleanAllMediator()
		: base(null)
	{
	}
}
