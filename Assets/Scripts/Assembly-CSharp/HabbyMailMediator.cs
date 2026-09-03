using System.Collections.Generic;

public class HabbyMailMediator : MediatorBase
{
	public new const string NAME = "HabbyMailMediator";

	public override List<string> OnListNotificationInterests => null;

	public HabbyMailMediator()
		: base(null)
	{
	}
}
