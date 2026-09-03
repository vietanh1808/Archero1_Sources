using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class PVESeasonGiftItemData
{
	private STCommonGiftData giftData;

	public int gid => 0;

	public string price => null;

	public List<Drop_DropModel.DropData> rewards => null;

	public int discount => 0;

	public int have => 0;

	public int max => 0;

	public int reset => 0;

	public int show => 0;

	public int pos => 0;

	public bool canGet => false;

	public bool haveleft => false;

	public PVESeasonGiftItemData(STCommonGiftData _data)
	{
	}

	public void AddBuyCount()
	{
	}
}
