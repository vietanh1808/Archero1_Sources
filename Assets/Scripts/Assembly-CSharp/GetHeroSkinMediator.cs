using System.Collections.Generic;

public class GetHeroSkinMediator : MediatorBase
{
	public new const string NAME = "GetHeroSkinMediator";

	public override List<string> OnListNotificationInterests => null;

	public GetHeroSkinMediator()
		: base(null)
	{
	}
}
