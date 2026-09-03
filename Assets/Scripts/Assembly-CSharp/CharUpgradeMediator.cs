using System.Collections.Generic;

public class CharUpgradeMediator : MediatorBase
{
	public new const string NAME = "CharUpgradeMediator";

	public override List<string> OnListNotificationInterests => null;

	public CharUpgradeMediator()
		: base(null)
	{
	}
}
