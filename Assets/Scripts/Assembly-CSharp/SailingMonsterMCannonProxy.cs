using PureMVC.Patterns;

public class SailingMonsterMCannonProxy : Proxy
{
	public class Transfer
	{
		public int? selectIronArrowCount;

		public int? selectGoldArrowCount;
	}

	public new const string NAME = "SailingMonsterMCannonProxy";

	public SailingMonsterMCannonProxy(object data)
	{
	}
}
