using System.Collections.Generic;

public class MountainShopMediator : MediatorBase
{
	public new const string NAME = "MountainShopMediator";

	public override List<string> OnListNotificationInterests => null;

	public MountainShopMediator()
		: base(null)
	{
	}
}
