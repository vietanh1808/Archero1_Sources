using System.Collections.Generic;

public class DragonCombineUIMediator : MediatorBase
{
	public new const string NAME = "DragonCombineUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public DragonCombineUIMediator()
		: base(null)
	{
	}
}
