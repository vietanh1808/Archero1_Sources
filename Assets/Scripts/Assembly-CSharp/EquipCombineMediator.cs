using System.Collections.Generic;

public class EquipCombineMediator : MediatorBase
{
	public new const string NAME = "EquipCombineMediator";

	public override List<string> OnListNotificationInterests => null;

	public EquipCombineMediator()
		: base(null)
	{
	}
}
