using System.Collections.Generic;

public class PetSkillUpUIMediator : MediatorBase
{
	public new const string NAME = "PetSkillUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PetSkillUpUIMediator()
		: base(null)
	{
	}
}
