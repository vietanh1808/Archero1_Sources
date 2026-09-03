using System.Collections.Generic;

public class EggAttributeMediator : MediatorBase
{
	public new const string NAME = "EggAttributeMediator";

	public override List<string> OnListNotificationInterests => null;

	public EggAttributeMediator()
		: base(null)
	{
	}
}
