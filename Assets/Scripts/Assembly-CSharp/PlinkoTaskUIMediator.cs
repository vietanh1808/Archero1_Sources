using System.Collections.Generic;

public class PlinkoTaskUIMediator : MediatorBase
{
	public new const string NAME = "PlinkoTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlinkoTaskUIMediator()
		: base(null)
	{
	}
}
