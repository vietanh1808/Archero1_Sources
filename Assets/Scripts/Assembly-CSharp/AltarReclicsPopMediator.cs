using System.Collections.Generic;

public class AltarReclicsPopMediator : MediatorBase
{
	public new const string NAME = "AltarRelicsPopMediator";

	public override List<string> OnListNotificationInterests => null;

	public AltarReclicsPopMediator()
		: base(null)
	{
	}
}
