using System.Collections.Generic;

public class MonopolyTaskUIMediator : MediatorBase
{
	public new const string NAME = "MonopolyTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyTaskUIMediator()
		: base(null)
	{
	}
}
