using System.Collections.Generic;

public class AltarPopMediator : MediatorBase
{
	public new const string NAME = "AltarPopMediator";

	public override List<string> OnListNotificationInterests => null;

	public AltarPopMediator()
		: base(null)
	{
	}
}
