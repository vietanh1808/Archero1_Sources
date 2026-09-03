using System.Collections.Generic;

public class HeroFragmentExchangeMediator : MediatorBase
{
	public new const string NAME = "HeroFragmentExchangeMediator";

	public override List<string> OnListNotificationInterests => null;

	public HeroFragmentExchangeMediator()
		: base(null)
	{
	}
}
