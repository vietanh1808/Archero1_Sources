using System.Collections.Generic;

public class ChooseHeroSkillMediator : MediatorBase
{
	public new const string NAME = "ChooseHeroSkillMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseHeroSkillMediator()
		: base(null)
	{
	}
}
