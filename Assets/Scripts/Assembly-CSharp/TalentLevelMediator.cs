using System.Collections.Generic;

public class TalentLevelMediator : MediatorBase
{
	public new const string NAME = "TalentLevelMediator";

	public override List<string> OnListNotificationInterests => null;

	public TalentLevelMediator()
		: base(null)
	{
	}
}
