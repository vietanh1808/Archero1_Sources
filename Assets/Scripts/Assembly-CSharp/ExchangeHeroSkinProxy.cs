using System;
using PureMVC.Patterns;
using TableTool;

public class ExchangeHeroSkinProxy : Proxy
{
	public class Transfer
	{
		public PlayerCharacter_Character data;

		public int index;

		public Action UpdateSelectedSkinAction;
	}

	public new const string NAME = "ExchangeHeroSkinProxy";

	public ExchangeHeroSkinProxy(object data)
	{
	}
}
