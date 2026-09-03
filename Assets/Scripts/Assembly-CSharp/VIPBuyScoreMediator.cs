using System.Collections.Generic;

public class VIPBuyScoreMediator : MediatorBase
{
	public new const string NAME = "VIPBuyScoreMediator";

	public override List<string> OnListNotificationInterests => null;

	public VIPBuyScoreMediator()
		: base(null)
	{
	}
}
