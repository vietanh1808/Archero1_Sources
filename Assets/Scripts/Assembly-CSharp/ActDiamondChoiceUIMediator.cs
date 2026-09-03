using System.Collections.Generic;

public class ActDiamondChoiceUIMediator : MediatorBase
{
	public new const string NAME = "DiamondChoiceUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActDiamondChoiceUIMediator()
		: base(null)
	{
	}
}
