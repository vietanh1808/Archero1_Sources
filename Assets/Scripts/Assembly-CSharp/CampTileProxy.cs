using PureMVC.Patterns;
using XLua;

public class CampTileProxy : Proxy
{
	public class Transfer<T> where T : CampTileBaseConfigData
	{
		public CampTileBaseData<T> data;
	}

	public new const string NAME = "CampTileProxy";

	private static DelegateBridge _c__Hotfix0_ctor;

	public CampTileProxy(object data)
	{
	}
}
