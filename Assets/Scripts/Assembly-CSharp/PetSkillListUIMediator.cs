using System.Collections.Generic;

public class PetSkillListUIMediator : MediatorBase
{
	public new const string NAME = "PetSkillListUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PetSkillListUIMediator()
		: base(null)
	{
	}
}
