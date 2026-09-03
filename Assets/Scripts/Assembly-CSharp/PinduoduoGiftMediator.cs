using System.Collections.Generic;

public class PinduoduoGiftMediator : MediatorBase
{
	public new const string NAME = "PinduoduoGiftMediator";

	public override List<string> OnListNotificationInterests => null;

	public PinduoduoGiftMediator()
		: base(null)
	{
	}
}
