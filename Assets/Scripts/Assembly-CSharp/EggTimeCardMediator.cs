using System.Collections.Generic;

public class EggTimeCardMediator : MediatorBase
{
	public new const string NAME = "EggTimeCardMediator";

	public override List<string> OnListNotificationInterests => null;

	public EggTimeCardMediator()
		: base(null)
	{
	}
}
