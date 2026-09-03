using System.Collections.Generic;

public class HallExchCostUIMediator : MediatorBase
{
	public new const string NAME = "HallExchCostUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HallExchCostUIMediator()
		: base(null)
	{
	}
}
