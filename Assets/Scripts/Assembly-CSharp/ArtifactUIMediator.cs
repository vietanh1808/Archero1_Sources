using System.Collections.Generic;

public class ArtifactUIMediator : MediatorBase
{
	public new const string NAME = "ArtifactUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ArtifactUIMediator()
		: base(null)
	{
	}
}
