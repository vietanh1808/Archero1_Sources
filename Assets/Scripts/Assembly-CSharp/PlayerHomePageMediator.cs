using System.Collections.Generic;

public class PlayerHomePageMediator : MediatorBase
{
	public new const string NAME = "PlayerHomePageMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlayerHomePageMediator()
		: base(null)
	{
	}
}
