using System.Collections.Generic;

public class MiningGiftUIMediator : MediatorBase
{
	public new const string NAME = "MiningGiftUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MiningGiftUIMediator()
		: base(null)
	{
	}
}
