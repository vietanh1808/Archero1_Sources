using System.Collections.Generic;

public class PlinkoGiftUIMediator : MediatorBase
{
	public new const string NAME = "PlinkoGiftUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlinkoGiftUIMediator()
		: base(null)
	{
	}
}
