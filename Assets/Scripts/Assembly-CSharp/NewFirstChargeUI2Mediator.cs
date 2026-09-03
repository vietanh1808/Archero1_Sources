using System.Collections.Generic;

public class NewFirstChargeUI2Mediator : MediatorBase
{
	public new const string NAME = "NewFirstChargeUI2Mediator";

	public override List<string> OnListNotificationInterests => null;

	public NewFirstChargeUI2Mediator()
		: base(null)
	{
	}
}
