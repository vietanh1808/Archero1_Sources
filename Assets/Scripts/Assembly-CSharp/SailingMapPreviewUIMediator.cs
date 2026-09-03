using System.Collections.Generic;

public class SailingMapPreviewUIMediator : MediatorBase
{
	public new const string NAME = "SailingMapPreviewUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingMapPreviewUIMediator()
		: base(null)
	{
	}
}
