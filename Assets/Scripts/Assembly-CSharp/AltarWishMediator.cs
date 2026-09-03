using System.Collections.Generic;

public class AltarWishMediator : MediatorBase
{
	public new const string NAME = "AltarWishMediator";

	public override List<string> OnListNotificationInterests => null;

	public AltarWishMediator()
		: base(null)
	{
	}
}
