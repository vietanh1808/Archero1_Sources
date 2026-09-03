using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MonopolyGiftData
{
	public List<MonopolyGiftItemData> monopolyGiftItemDatas;

	[CompilerGenerated]
	private Action m_OnGiftGet;

	public long LeftTime => 0L;

	public event Action OnGiftGet
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

	public List<MonopolyGiftItemData> GetAll()
	{
		return null;
	}

	public void RequestMonopolyGift(MonopolyGiftItemData giftData)
	{
	}
}
