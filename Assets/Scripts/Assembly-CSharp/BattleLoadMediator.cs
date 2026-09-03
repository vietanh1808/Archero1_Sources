using System.Collections.Generic;

public class BattleLoadMediator : MediatorBase
{
	public new const string NAME = "BattleLoadMediator";

	public override List<string> OnListNotificationInterests => null;

	public BattleLoadMediator()
		: base(null)
	{
	}
}
