using System.Collections.Generic;

public class AltarUpMediator : MediatorBase
{
	public new const string NAME = "AltarUpMediator";

	public override List<string> OnListNotificationInterests => null;

	public AltarUpMediator()
		: base(null)
	{
	}
}
