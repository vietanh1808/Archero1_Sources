using System.Collections.Generic;

public class ChooseNpcSkillModuleMediator : MediatorBase
{
	public new const string NAME = "ChooseNpcSkillModuleMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseNpcSkillModuleMediator()
		: base(null)
	{
	}
}
