using System;
using PureMVC.Patterns;

public class CampBattleReOpenProxy : Proxy
{
	public class Transfer
	{
		public CampTileReOpenTransData data;

		public Action success;

		public Action failure;
	}

	public new const string NAME = "CampBattleReOpenProxy";

	public CampBattleReOpenProxy(object data)
	{
	}
}
