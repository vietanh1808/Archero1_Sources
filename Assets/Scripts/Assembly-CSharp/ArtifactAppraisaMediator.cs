using System.Collections.Generic;

public class ArtifactAppraisaMediator : MediatorBase
{
	public new const string NAME = "ArtifactAppraisaMediator";

	public override List<string> OnListNotificationInterests => null;

	public ArtifactAppraisaMediator()
		: base(null)
	{
	}
}
