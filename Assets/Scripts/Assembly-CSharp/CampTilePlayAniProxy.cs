using System.Collections.Generic;
using GameProtocol;
using PureMVC.Patterns;
using XLua;

public class CampTilePlayAniProxy : Proxy
{
	public class Transfer
	{
		public List<CampTileArrowDamageData> damageData;

		public CRespCampBlock response;

		public int oldLevel;

		public CampTileOccupyAttackType attackType;

		public int returnIronArrow;

		public int returnGoldArrow;

		public CampID recordOccupyCamp;

		public int attackMonsterCampID;
	}

	public new const string NAME = "CampTilePlayAniProxy";

	private static DelegateBridge _c__Hotfix0_ctor;

	public CampTilePlayAniProxy(object data)
	{
	}
}
