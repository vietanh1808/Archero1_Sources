using System.Collections.Generic;

public class ChooseNPCDragonSkillsMediator : MediatorBase
{
	public new const string NAME = "ChooseNPCDragonSkillsMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseNPCDragonSkillsMediator()
		: base(null)
	{
	}
}
