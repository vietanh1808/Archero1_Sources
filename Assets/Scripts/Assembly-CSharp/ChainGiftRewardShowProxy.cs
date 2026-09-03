using System.Collections.Generic;
using PureMVC.Patterns;
using UnityEngine;

public class ChainGiftRewardShowProxy : Proxy
{
	public class Transfer
	{
		public List<string> data;

		public Vector3 pos;

		public BattlePassChestInformation.TipPosition tipPos;
	}

	public new const string NAME = "ChainGiftRewardShowProxy";

	public ChainGiftRewardShowProxy(object data)
	{
	}
}
