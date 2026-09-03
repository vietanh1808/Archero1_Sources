using System.Collections.Generic;

public class HellStageInfoUIMediator : MediatorBase
{
	public new const string NAME = "HellStageInfoUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HellStageInfoUIMediator()
		: base(null)
	{
	}
}
