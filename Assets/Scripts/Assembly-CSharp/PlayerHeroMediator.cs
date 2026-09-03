using System.Collections.Generic;

public class PlayerHeroMediator : MediatorBase
{
	public new const string NAME = "PlayerHeroMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlayerHeroMediator()
		: base(null)
	{
	}
}
