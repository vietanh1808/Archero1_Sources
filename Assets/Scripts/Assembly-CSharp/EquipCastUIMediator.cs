using System.Collections.Generic;

public class EquipCastUIMediator : MediatorBase
{
	public new const string NAME = "EquipCastUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public EquipCastUIMediator()
		: base(null)
	{
	}
}
