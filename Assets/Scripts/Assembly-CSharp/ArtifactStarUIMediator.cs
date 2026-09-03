using System.Collections.Generic;

public class ArtifactStarUIMediator : MediatorBase
{
	public new const string NAME = "ArtifactStarUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ArtifactStarUIMediator()
		: base(null)
	{
	}
}
