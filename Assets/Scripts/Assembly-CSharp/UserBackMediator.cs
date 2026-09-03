using System.Collections.Generic;

public class UserBackMediator : MediatorBase
{
	public new static readonly string NAME;

	public override List<string> OnListNotificationInterests => null;

	public UserBackMediator()
		: base(null)
	{
	}
}
