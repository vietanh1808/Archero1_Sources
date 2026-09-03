using System.Collections.Generic;

public class DoubleChallengeReportMediator : MediatorBase
{
	public new const string NAME = "DoubleChallengeReportMediator";

	public override List<string> OnListNotificationInterests => null;

	public DoubleChallengeReportMediator()
		: base(null)
	{
	}
}
