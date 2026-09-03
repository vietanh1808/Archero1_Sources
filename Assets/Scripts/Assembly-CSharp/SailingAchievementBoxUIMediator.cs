using System.Collections.Generic;

public class SailingAchievementBoxUIMediator : MediatorBase
{
	public new const string NAME = "SailingAchievementBoxUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingAchievementBoxUIMediator()
		: base(null)
	{
	}
}
