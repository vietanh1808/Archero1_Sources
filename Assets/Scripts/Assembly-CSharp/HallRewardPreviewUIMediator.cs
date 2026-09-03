using System.Collections.Generic;

public class HallRewardPreviewUIMediator : MediatorBase
{
	public new const string NAME = "HallRewardPreviewUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HallRewardPreviewUIMediator()
		: base(null)
	{
	}
}
