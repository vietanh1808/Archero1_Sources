using System.Collections.Generic;

public class ChangeWeaponMediator : MediatorBase
{
	public new const string NAME = "ChangeWeaponMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChangeWeaponMediator()
		: base(null)
	{
	}
}
