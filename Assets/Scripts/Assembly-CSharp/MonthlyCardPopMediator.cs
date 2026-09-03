using System.Collections.Generic;

public class MonthlyCardPopMediator : MediatorBase
{
	public new const string NAME = "MonthlyCardPopMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonthlyCardPopMediator()
		: base(null)
	{
	}
}
