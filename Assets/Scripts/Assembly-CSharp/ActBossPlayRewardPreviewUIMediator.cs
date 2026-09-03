using System.Collections.Generic;

public class ActBossPlayRewardPreviewUIMediator : MediatorBase
{
	public new const string NAME = "ActBossPlayUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActBossPlayRewardPreviewUIMediator()
		: base(null)
	{
	}
}
