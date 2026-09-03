using System;
using Newtonsoft.Json;
using XLua;

[Serializable]
public class Gift2023ItemConfigData
{
	public int id;

	public string Product_id;

	public int discount;

	[JsonIgnore]
	public int haveBuyCount;

	public int Quota;

	public int show_cond;

	public int DailyReset;

	public int[][] Optional;

	public int Position;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void AddBuyCount()
	{
	}

	public void UpdateBuyCount(int buyCount)
	{
	}
}
