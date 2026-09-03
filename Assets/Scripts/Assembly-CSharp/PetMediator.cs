using System.Collections.Generic;

public class PetMediator : MediatorBase
{
	public new const string NAME = "PetMediator";

	public override List<string> OnListNotificationInterests => null;

	public PetMediator()
		: base(null)
	{
	}
}
