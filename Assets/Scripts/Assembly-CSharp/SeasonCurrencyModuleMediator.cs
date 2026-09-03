using System.Collections.Generic;

public class SeasonCurrencyModuleMediator : MediatorBase
{
	public new const string NAME = "SeasonCurrencyModuleMediator";

	public override List<string> OnListNotificationInterests => null;

	public SeasonCurrencyModuleMediator()
		: base(null)
	{
	}
}
