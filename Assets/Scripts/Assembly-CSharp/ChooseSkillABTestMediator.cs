using System.Collections.Generic;

public class ChooseSkillABTestMediator : MediatorBase
{
	public new const string NAME = "ChooseSkillABTestMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseSkillABTestMediator()
		: base(null)
	{
	}
}
