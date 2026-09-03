using System;
using PureMVC.Patterns;
using TableTool;

public class GetHeroSkinProxy : Proxy
{
	public class Transfer
	{
		public PlayerCharacter_Skin data;

		public string source;

		public int cost;

		public Action close;

		public void SetData(PlayerCharacter_Skin data, string source, int cost)
		{
		}

		public void SetData(PlayerCharacter_Skin data, string source, int cost, Action close)
		{
		}
	}

	public new const string NAME = "GetHeroSkinProxy";

	public GetHeroSkinProxy(object data)
	{
	}
}
