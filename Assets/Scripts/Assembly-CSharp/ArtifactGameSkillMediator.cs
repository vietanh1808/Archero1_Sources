using System.Collections.Generic;

public class ArtifactGameSkillMediator : MediatorBase
{
	public new const string NAME = "ArtifactGameSkillMediator";

	public override List<string> OnListNotificationInterests => null;

	public ArtifactGameSkillMediator()
		: base(null)
	{
	}
}
