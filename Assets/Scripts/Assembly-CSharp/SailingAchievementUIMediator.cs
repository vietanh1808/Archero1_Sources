using System.Collections.Generic;

public class SailingAchievementUIMediator : MediatorBase
{
	public new const string NAME = "SailingAchievementUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingAchievementUIMediator()
		: base(null)
	{
	}
}
