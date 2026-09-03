using System.Collections.Generic;

public class ArtifactTipsUIMediator : MediatorBase
{
	public new const string NAME = "ArtifactTipsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ArtifactTipsUIMediator()
		: base(null)
	{
	}
}
