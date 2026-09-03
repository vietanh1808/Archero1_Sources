using System;
using System.Collections.Generic;

public class CommonQuickBuyItemData
{
	public int type;

	public int pid;

	public int have;

	public int max;

	public List<int> priceList;

	public Action okAction;

	public int choose;

	public int unit;

	public int style;

	public bool priceMore => false;

	public int calcutePrice(int count)
	{
		return 0;
	}
}
