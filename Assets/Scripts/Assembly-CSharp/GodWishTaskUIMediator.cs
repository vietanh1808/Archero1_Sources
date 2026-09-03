using System.Collections.Generic;

public class GodWishTaskUIMediator : MediatorBase
{
	public new const string NAME = "GodWishTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GodWishTaskUIMediator()
		: base(null)
	{
	}
}
