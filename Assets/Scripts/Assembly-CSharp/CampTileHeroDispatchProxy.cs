using PureMVC.Patterns;
using XLua;

public class CampTileHeroDispatchProxy : Proxy
{
	public class Transfer
	{
		public CampTileResourceType resourceType;

		public (int, int) curResourcePos;

		public LocalSave.CharacterOne dispatchHeroData;

		public int dispatchHeadImgID;
	}

	public class SelectTransfer
	{
		public int selectHeroID;
	}

	public new const string NAME = "CampTileHeroDispatchProxy";

	private static DelegateBridge _c__Hotfix0_ctor;

	public CampTileHeroDispatchProxy(object data)
	{
	}
}
