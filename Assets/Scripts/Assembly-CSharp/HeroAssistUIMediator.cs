using System.Collections.Generic;

public class HeroAssistUIMediator : MediatorBase
{
	public new const string NAME = "HeroAssistUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HeroAssistUIMediator()
		: base(null)
	{
	}
}
