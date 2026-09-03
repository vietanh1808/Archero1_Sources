using System.Collections.Generic;

public class WeaponInfoMediator : MediatorBase
{
	public new const string NAME = "WeaponInfoMediator";

	public override List<string> OnListNotificationInterests => null;

	public WeaponInfoMediator()
		: base(null)
	{
	}
}
