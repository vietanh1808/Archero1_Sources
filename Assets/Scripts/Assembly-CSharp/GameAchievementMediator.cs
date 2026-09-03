using System.Collections.Generic;

public class GameAchievementMediator : MediatorBase
{
	public new const string NAME = "GameAchievementMediator";

	public override List<string> OnListNotificationInterests => null;

	public GameAchievementMediator()
		: base(null)
	{
	}
}
