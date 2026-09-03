using System.Collections.Generic;

public class EquipStoragePageUIMediator : MediatorBase
{
	public const string Name = "EquipStoragePageUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public EquipStoragePageUIMediator()
		: base(null)
	{
	}
}
