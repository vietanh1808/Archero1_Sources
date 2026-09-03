using PureMVC.Interfaces;
using PureMVC.Patterns;

public class UnlockStageHellProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public GameMode Mode;

		public int StageID;
	}

	public new const string NAME = "UnlockStageHellProxy";

	public UnlockStageHellProxy(object data)
	{
	}
}
