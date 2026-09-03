using PureMVC.Interfaces;
using PureMVC.Patterns;

public class UnlockStageHeroProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public GameMode Mode;

		public int StageID;
	}

	public new const string NAME = "UnlockStageHeroProxy";

	public UnlockStageHeroProxy(object data)
	{
	}
}
