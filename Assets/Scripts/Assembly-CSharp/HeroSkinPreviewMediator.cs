using System.Collections.Generic;

public class HeroSkinPreviewMediator : MediatorBase
{
	public new const string NAME = "HeroSkinPreviewMediator";

	public override List<string> OnListNotificationInterests => null;

	public HeroSkinPreviewMediator()
		: base(null)
	{
	}
}
