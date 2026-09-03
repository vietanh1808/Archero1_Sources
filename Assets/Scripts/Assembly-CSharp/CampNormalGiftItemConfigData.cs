using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class CampNormalGiftItemConfigData
{
	public int id;

	public int Position;

	public string Product_id;

	public int discount;

	public int haveBuyCount;

	public int Quota;

	public int show_cond;

	public int DailyReset;

	public List<List<int>> Optional;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge __Hotfix0_ResetBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void AddBuyCount(int count)
	{
	}

	public void UpdateData(int buyCount)
	{
	}

	public void ResetBuyCount()
	{
	}
}
