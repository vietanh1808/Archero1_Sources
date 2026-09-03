using System.Collections.Generic;

public class ArtifactSkillTipsUIMediator : MediatorBase
{
	public new const string NAME = "ArtifactSkillTipsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ArtifactSkillTipsUIMediator()
		: base(null)
	{
	}
}
