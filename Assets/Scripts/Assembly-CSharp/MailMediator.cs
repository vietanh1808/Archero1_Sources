using System.Collections.Generic;

public class MailMediator : MediatorBase
{
	public new const string NAME = "MailMediator";

	public override List<string> OnListNotificationInterests => null;

	public MailMediator()
		: base(null)
	{
	}
}
