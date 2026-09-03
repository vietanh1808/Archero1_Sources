using System.Collections.Generic;

public class ChooseInitWeaponMediator : MediatorBase
{
	public new const string NAME = "ChooseInitWeaponMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseInitWeaponMediator()
		: base(null)
	{
	}
}
