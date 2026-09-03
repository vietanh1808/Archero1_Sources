using System.Collections.Generic;

public class TimeEnvelopeUIMediator : MediatorBase
{
	public new const string NAME = "TimeEnvelopeUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public TimeEnvelopeUIMediator()
		: base(null)
	{
	}
}
