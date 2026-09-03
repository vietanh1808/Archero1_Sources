using System.Collections.Generic;

public class DebugPanelMediator : MediatorBase
{
	public new const string NAME = "DebugPanelMediator";

	public override List<string> OnListNotificationInterests => null;

	public DebugPanelMediator()
		: base(null)
	{
	}
}
