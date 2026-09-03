using System.Collections.Generic;

public class CurrencyModuleMediator : MediatorBase
{
	public new const string NAME = "CurrencyModuleMediator";

	public override List<string> OnListNotificationInterests => null;

	public CurrencyModuleMediator()
		: base(null)
	{
	}
}
