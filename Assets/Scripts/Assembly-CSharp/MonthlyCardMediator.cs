using System.Collections.Generic;

public class MonthlyCardMediator : MediatorBase
{
	public new const string NAME = "MonthlyCardMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonthlyCardMediator()
		: base(null)
	{
	}
}
