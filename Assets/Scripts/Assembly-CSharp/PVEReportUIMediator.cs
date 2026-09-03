using System.Collections.Generic;

public class PVEReportUIMediator : MediatorBase
{
	public new const string NAME = "PVEReportUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PVEReportUIMediator()
		: base(null)
	{
	}
}
