using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class Vault2023ConfigParse
{
	public int[] Exchange_Preview;

	public List<Vault2023GameShowRewardItemConfigData> Item_Reward;

	public List<Gift2023ItemConfigData> Gift;

	public List<List<Exchange2023ItemConfigData>> ExchangeNormal;

	public List<Exchange2023ItemConfigData> ExchangeSuper;

	private static DelegateBridge _c__Hotfix0_ctor;
}
