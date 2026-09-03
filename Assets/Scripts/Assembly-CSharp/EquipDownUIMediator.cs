using System.Collections.Generic;

public class EquipDownUIMediator : MediatorBase
{
	public new const string NAME = "EquipDownUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public EquipDownUIMediator()
		: base(null)
	{
	}
}
