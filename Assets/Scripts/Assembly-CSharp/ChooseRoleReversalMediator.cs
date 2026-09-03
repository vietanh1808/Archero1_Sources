using System.Collections.Generic;

public class ChooseRoleReversalMediator : MediatorBase
{
	public new const string NAME = "ChooseRoleReversalMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseRoleReversalMediator()
		: base(null)
	{
	}
}
