using System.Collections.Generic;

public class SeasonTopicMediator : MediatorBase
{
	public new const string NAME = "SeasonTopicMediator";

	public override List<string> OnListNotificationInterests => null;

	public SeasonTopicMediator()
		: base(null)
	{
	}
}
