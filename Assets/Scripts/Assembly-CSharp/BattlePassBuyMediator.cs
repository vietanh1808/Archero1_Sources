using System.Collections.Generic;

public class BattlePassBuyMediator : MediatorBase
{
	public new const string NAME = "BattlePassBuyMediator";

	public override List<string> OnListNotificationInterests => null;

	public BattlePassBuyMediator()
		: base(null)
	{
	}
}
