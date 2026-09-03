using System.Collections.Generic;

public class BadgeBagPreviewUIMediator : MediatorBase
{
	public new const string NAME = "BadgeBagPreviewUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeBagPreviewUIMediator()
		: base(null)
	{
	}
}
