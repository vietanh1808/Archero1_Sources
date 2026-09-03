using System.Collections.Generic;

public class HeroAssistUpUIMediator : MediatorBase
{
	public new const string NAME = "HeroAssistUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HeroAssistUpUIMediator()
		: base(null)
	{
	}
}
