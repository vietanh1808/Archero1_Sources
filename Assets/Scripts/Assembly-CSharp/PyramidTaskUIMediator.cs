using System.Collections.Generic;

public class PyramidTaskUIMediator : MediatorBase
{
	public new const string NAME = "PyramidTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PyramidTaskUIMediator()
		: base(null)
	{
	}
}
