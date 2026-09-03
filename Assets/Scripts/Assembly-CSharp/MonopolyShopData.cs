using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MonopolyShopData
{
	public List<MonopolyShopItemData> monopolyShopItemDatas;

	[CompilerGenerated]
	private Action m_OnShopGet;

	public long LeftTime => 0L;

	public event Action OnShopGet
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public List<MonopolyShopItemData> GetAll()
	{
		return null;
	}

	public void RequestMonopolyShop(MonopolyShopItemData giftData, int count)
	{
	}
}
