using System.Collections.Generic;

public class BattlePassBuyNewMediator : MediatorBase
{
	public new const string NAME = "BattlePassBuyMediator";

	public override List<string> OnListNotificationInterests => null;

	public BattlePassBuyNewMediator()
		: base(null)
	{
	}
}
