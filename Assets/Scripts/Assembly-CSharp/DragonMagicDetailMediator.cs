using System.Collections.Generic;

public class DragonMagicDetailMediator : MediatorBase
{
	public new const string NAME = "DragonMagicDetailMediator";

	public override List<string> OnListNotificationInterests => null;

	public DragonMagicDetailMediator()
		: base(null)
	{
	}
}
