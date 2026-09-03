using System.Collections.Generic;

public class PveSeasonBattlePassMediator : MediatorBase
{
	public new const string NAME = "SeasonBattlePassBuyMediator";

	public override List<string> OnListNotificationInterests => null;

	public PveSeasonBattlePassMediator()
		: base(null)
	{
	}
}
