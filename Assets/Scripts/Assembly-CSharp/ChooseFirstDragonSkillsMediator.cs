using System.Collections.Generic;

public class ChooseFirstDragonSkillsMediator : MediatorBase
{
	public new const string NAME = "ChooseFirstDragonSkillsMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseFirstDragonSkillsMediator()
		: base(null)
	{
	}
}
