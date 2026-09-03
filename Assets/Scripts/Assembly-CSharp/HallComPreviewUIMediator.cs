using System.Collections.Generic;

public class HallComPreviewUIMediator : MediatorBase
{
	public new const string NAME = "HallComPreviewUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HallComPreviewUIMediator()
		: base(null)
	{
	}
}
