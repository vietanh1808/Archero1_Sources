using System.Collections.Generic;

public class SeasonChooseHeroUIMediator : MediatorBase
{
	public new const string NAME = "SeasonChooseHeroUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SeasonChooseHeroUIMediator()
		: base(null)
	{
	}
}
