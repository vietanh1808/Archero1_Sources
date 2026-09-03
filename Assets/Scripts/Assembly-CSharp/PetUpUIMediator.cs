using System.Collections.Generic;

public class PetUpUIMediator : MediatorBase
{
	public new const string NAME = "PetUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PetUpUIMediator()
		: base(null)
	{
	}
}
