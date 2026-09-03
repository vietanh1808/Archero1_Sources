using System.Collections.Generic;

public class PiggyBankUIMediator : MediatorBase
{
	public new const string NAME = "PiggyBankUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PiggyBankUIMediator()
		: base(null)
	{
	}
}
