using System.Collections.Generic;

public class ActBagLikeDiffSelectUIMediator : MediatorBase
{
	public new const string NAME = "ActBagLikeDiffSelectUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActBagLikeDiffSelectUIMediator()
		: base(null)
	{
	}
}
