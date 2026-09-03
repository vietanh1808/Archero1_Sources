using System.Collections.Generic;
using GameProtocol;
using PureMVC.Patterns;

public class SailingMonsterPlayAniProxy : Proxy
{
	public class Transfer
	{
		public List<SailingMonsterMCannonDamageData> damageData;

		public CRespShipBattleSeasonFire response;

		public int oldLevel;
	}

	public new const string NAME = "SailingMonsterPlayAniProxy";

	public SailingMonsterPlayAniProxy(object data)
	{
	}
}
