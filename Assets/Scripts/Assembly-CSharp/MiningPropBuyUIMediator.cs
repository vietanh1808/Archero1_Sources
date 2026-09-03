using System.Collections.Generic;

public class MiningPropBuyUIMediator : MediatorBase
{
	public new const string NAME = "MiningPropBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MiningPropBuyUIMediator()
		: base(null)
	{
	}
}
