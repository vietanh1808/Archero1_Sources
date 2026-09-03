using System.Collections.Generic;

public class ManorExchInfoUIMediator : MediatorBase
{
	public new const string NAME = "ManorExchInfoUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorExchInfoUIMediator()
		: base(null)
	{
	}
}
