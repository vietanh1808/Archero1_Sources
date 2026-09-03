using System.Collections.Generic;

public class WeaponSkinUIMediator : MediatorBase
{
	public new const string NAME = "WeaponSkinUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public WeaponSkinUIMediator()
		: base(null)
	{
	}
}
