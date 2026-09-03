using System.Collections.Generic;

public class ActivityBingoMediator : MediatorBase
{
	public new const string NAME = "ActivityBingoMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActivityBingoMediator()
		: base(null)
	{
	}
}
