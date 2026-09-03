using System.Collections.Generic;

public class ActPyramidTreasureMediator : MediatorBase
{
	public new const string NAME = "ActPyramidTreasureMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActPyramidTreasureMediator()
		: base(null)
	{
	}
}
