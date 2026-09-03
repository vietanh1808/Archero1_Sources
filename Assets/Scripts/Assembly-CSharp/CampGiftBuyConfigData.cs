using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class CampGiftBuyConfigData
{
	public Dictionary<string, int> daily;

	public Dictionary<string, int> war;

	public Dictionary<string, int> camp;

	public List<CampGiftBuyItemConfigData> timing;

	private static DelegateBridge _c__Hotfix0_ctor;
}
