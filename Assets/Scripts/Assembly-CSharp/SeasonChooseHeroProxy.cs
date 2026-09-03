using System;
using PureMVC.Patterns;

public class SeasonChooseHeroProxy : Proxy
{
	public class Transfer
	{
		public Action OnClose;
	}

	public new const string NAME = "SeasonChooseHeroProxy";

	public SeasonChooseHeroProxy(object data)
	{
	}
}
