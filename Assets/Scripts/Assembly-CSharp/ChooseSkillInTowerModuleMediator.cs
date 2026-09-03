using System.Collections.Generic;

public class ChooseSkillInTowerModuleMediator : MediatorBase
{
	public new const string NAME = "ChooseSkillInTowerModuleMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseSkillInTowerModuleMediator()
		: base(null)
	{
	}
}
