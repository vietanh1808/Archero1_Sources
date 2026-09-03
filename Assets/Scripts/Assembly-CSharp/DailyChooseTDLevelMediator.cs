using System.Collections.Generic;

public class DailyChooseTDLevelMediator : MediatorBase
{
	public new const string NAME = "DailyChooseTDLevelMediator";

	public override List<string> OnListNotificationInterests => null;

	public DailyChooseTDLevelMediator()
		: base(null)
	{
	}
}
