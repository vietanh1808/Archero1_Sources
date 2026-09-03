using PureMVC.Interfaces;
using PureMVC.Patterns;

public class RelicInfoProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public LocalSave.EquipOne RelicOne;

		public bool isPreview;
	}

	public new const string NAME = "RelicInfoProxy";

	public RelicInfoProxy(object data)
	{
	}
}
