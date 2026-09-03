using System.Collections.Generic;

public class AltarReclicsUpMediator : MediatorBase
{
	public new const string NAME = "AltarRelicsUpMediator";

	public override List<string> OnListNotificationInterests => null;

	public AltarReclicsUpMediator()
		: base(null)
	{
	}
}
