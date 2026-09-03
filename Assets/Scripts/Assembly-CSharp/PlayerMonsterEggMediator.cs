using System.Collections.Generic;

public class PlayerMonsterEggMediator : MediatorBase
{
	public new const string NAME = "PlayerMonsterEggMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlayerMonsterEggMediator()
		: base(null)
	{
	}
}
