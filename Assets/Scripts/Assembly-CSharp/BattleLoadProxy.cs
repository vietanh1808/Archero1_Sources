using System;
using PureMVC.Patterns;

public class BattleLoadProxy : Proxy
{
	public enum LoadingType
	{
		eMiss = 0,
		eBattleStart = 1,
		eBattleEnd = 2
	}

	public class BattleLoadData
	{
		public Action LoadingDoPre;

		public Action LoadingDo;

		public Action LoadEnd1Do;

		public Action LoadEnd2Do;

		public LoadingType loadingType;

		public bool showLoading => false;

		public bool update_resolution => false;

		public bool reset_resolution => false;
	}

	public new const string NAME = "BattleLoadProxy";

	public BattleLoadProxy(object data)
	{
	}
}
