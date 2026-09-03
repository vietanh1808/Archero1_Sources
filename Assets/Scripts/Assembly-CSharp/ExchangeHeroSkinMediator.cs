using System.Collections.Generic;

public class ExchangeHeroSkinMediator : MediatorBase
{
	public new const string NAME = "ExchangeHeroSkinMediator";

	public override List<string> OnListNotificationInterests => null;

	public ExchangeHeroSkinMediator()
		: base(null)
	{
	}
}
