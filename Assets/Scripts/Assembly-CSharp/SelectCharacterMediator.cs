using System.Collections.Generic;

public class SelectCharacterMediator : MediatorBase
{
	public new const string NAME = "StageListHeroMediator";

	public override List<string> OnListNotificationInterests => null;

	public SelectCharacterMediator()
		: base(null)
	{
	}

	public override bool PreloadRes()
	{
		return false;
	}
}
