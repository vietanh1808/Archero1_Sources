using System.Collections.Generic;

public class HalloweenShopItemConfigData
{
	public int id;

	public int Position;

	public string Product_id;

	public List<List<int>> reward;

	public int Quota;

	public int discount;

	public int DailyReset;

	public int Show;

	public int haveBuyCount;

	public void UpdateBuyData(int haveBuyCount)
	{
	}

	public void AddBuyCount(int buyCount)
	{
	}

	public void PassDay()
	{
	}
}
