using System.Collections.Generic;

public class ArtifactPreviewUIMediator : MediatorBase
{
	public new const string NAME = "ArtifactPreviewUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ArtifactPreviewUIMediator()
		: base(null)
	{
	}
}
