using System.Collections.Generic;

public class MainActivityMediator : MediatorBase
{
	public new const string NAME = "MainActivityMediator";

	public override List<string> OnListNotificationInterests => null;

	public MainActivityMediator()
		: base(null)
	{
	}
}
