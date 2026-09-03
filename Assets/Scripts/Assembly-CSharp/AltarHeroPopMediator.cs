using System.Collections.Generic;

public class AltarHeroPopMediator : MediatorBase
{
	public new const string NAME = "AltarHeroPopMediator";

	public override List<string> OnListNotificationInterests => null;

	public AltarHeroPopMediator()
		: base(null)
	{
	}
}
