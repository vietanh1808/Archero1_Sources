using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class CampTimingGiftItemConfigData
{
	public int id;

	public string Product_id;

	public int discount;

	public int haveBuyCount;

	public int Quota;

	public long Time;

	public int show_cond;

	public List<List<int>> Optional;

	public long activeTime;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void AddBuyCount(int count)
	{
	}

	public void UpdateData(int count, long activeTime)
	{
	}
}
