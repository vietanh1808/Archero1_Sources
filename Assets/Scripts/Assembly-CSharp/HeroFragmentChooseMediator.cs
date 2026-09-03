using System.Collections.Generic;

public class HeroFragmentChooseMediator : MediatorBase
{
	public new const string NAME = "HeroFragmentChooseMediator";

	public override List<string> OnListNotificationInterests => null;

	public HeroFragmentChooseMediator()
		: base(null)
	{
	}
}
