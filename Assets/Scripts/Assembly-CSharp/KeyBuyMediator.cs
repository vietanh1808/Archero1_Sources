using System.Collections.Generic;

public class KeyBuyMediator : MediatorBase
{
	public new const string NAME = "KeyBuyMediator";

	public override List<string> OnListNotificationInterests => null;

	public KeyBuyMediator()
		: base(null)
	{
	}
}
