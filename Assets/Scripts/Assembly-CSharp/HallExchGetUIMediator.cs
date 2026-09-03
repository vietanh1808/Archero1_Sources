using System.Collections.Generic;

public class HallExchGetUIMediator : MediatorBase
{
	public new const string NAME = "HallExchGetUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HallExchGetUIMediator()
		: base(null)
	{
	}
}
