using System.Collections.Generic;

public class ChooseSkillModuleMediator : MediatorBase
{
	public new const string NAME = "ChooseSkillModuleMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseSkillModuleMediator()
		: base(null)
	{
	}
}
