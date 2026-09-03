using System.Collections.Generic;

public class NewChainGiftMediator : MediatorBase
{
	public new const string NAME = "NewChainGiftMediator";

	public override List<string> OnListNotificationInterests => null;

	public NewChainGiftMediator()
		: base(null)
	{
	}
}
