using System.Collections.Generic;

public class AltarHeroUpMediator : MediatorBase
{
	public new const string NAME = "AltarHeroUpMediator";

	public override List<string> OnListNotificationInterests => null;

	public AltarHeroUpMediator()
		: base(null)
	{
	}
}
