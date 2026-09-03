using System.Collections.Generic;

public class MonopolyGiftUIMediator : MediatorBase
{
	public new const string NAME = "MonopolyGiftUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyGiftUIMediator()
		: base(null)
	{
	}
}
