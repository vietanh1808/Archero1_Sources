using System.Collections.Generic;
using PureMVC.Patterns;

public class ChooseHeroInBattleProxy : Proxy
{
	public class Transfer
	{
		public long energy;

		public List<EntityPartBodyBase> myPartBodies;
	}

	public new const string NAME = "ChooseHeroInBattleProxy";

	public ChooseHeroInBattleProxy(object data)
	{
	}
}
