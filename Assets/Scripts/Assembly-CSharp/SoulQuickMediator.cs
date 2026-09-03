using System.Collections.Generic;

public class SoulQuickMediator : MediatorBase
{
	public new const string NAME = "SoulQuickMediator";

	public override List<string> OnListNotificationInterests => null;

	public SoulQuickMediator()
		: base(null)
	{
	}
}
