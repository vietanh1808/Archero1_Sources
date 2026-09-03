using System.Collections.Generic;

public class BPSecondTipsUIMediator : MediatorBase
{
	public new const string NAME = "BPSecondTipsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BPSecondTipsUIMediator()
		: base(null)
	{
	}
}
