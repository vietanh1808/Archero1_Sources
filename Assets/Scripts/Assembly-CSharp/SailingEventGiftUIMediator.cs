using System.Collections.Generic;

public class SailingEventGiftUIMediator : MediatorBase
{
	public new const string NAME = "SailingEventGiftUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingEventGiftUIMediator()
		: base(null)
	{
	}
}
