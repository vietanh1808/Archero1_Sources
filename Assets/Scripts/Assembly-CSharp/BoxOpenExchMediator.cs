using System.Collections.Generic;

public class BoxOpenExchMediator : MediatorBase
{
	public new const string NAME = "BoxOpenExchMediator";

	public override List<string> OnListNotificationInterests => null;

	public BoxOpenExchMediator()
		: base(null)
	{
	}
}
