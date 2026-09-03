using System.Collections.Generic;

public class BoxOpenGiftMediator : MediatorBase
{
	public new const string NAME = "BoxOpenGiftMediator";

	public override List<string> OnListNotificationInterests => null;

	public BoxOpenGiftMediator()
		: base(null)
	{
	}
}
