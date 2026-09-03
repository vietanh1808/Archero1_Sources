using System.Collections.Generic;

public class DailyChooseTowerMediator : MediatorBase
{
	public new const string NAME = "DailyChooseTowerMediator";

	public override List<string> OnListNotificationInterests => null;

	public DailyChooseTowerMediator()
		: base(null)
	{
	}
}
