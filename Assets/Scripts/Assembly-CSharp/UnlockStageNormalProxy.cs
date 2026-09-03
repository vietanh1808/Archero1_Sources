using PureMVC.Interfaces;
using PureMVC.Patterns;

public class UnlockStageNormalProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public GameMode Mode;

		public int StageID;
	}

	public new const string NAME = "UnlockStageNormalProxy";

	public UnlockStageNormalProxy(object data)
	{
	}
}
