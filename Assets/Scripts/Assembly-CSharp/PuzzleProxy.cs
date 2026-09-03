using PureMVC.Patterns;
using XLua;

public class PuzzleProxy : Proxy
{
	public class Transfer
	{
		public bool isChest;

		public int index;

		public PuzzleChestItemData data;
	}

	public new const string NAME = "PuzzleProxy";

	private static DelegateBridge _c__Hotfix0_ctor;

	public PuzzleProxy(object data)
	{
	}
}
