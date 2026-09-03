using System.Collections.Generic;

public class EquipCastEndUIMediator : MediatorBase
{
	public new const string NAME = "EquipCastEndUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public EquipCastEndUIMediator()
		: base(null)
	{
	}
}
