using System.Collections.Generic;

public class ChooseSkillPVPModuleMediator : MediatorBase
{
	public new const string NAME = "ChooseSkillPVPModuleMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseSkillPVPModuleMediator()
		: base(null)
	{
	}
}
