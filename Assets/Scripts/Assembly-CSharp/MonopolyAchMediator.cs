using System.Collections.Generic;

public class MonopolyAchMediator : MediatorBase
{
	public new const string NAME = "MonopolyAchMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyAchMediator()
		: base(null)
	{
	}
}
