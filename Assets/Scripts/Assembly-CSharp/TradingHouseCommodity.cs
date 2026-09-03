using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class TradingHouseCommodity
{
	public int EquipID;

	public Drop_DropModel.DropData Drop;

	public int[] vecCurPrice;

	public int[] HistoryPrice;

	public int Profit;

	public int netBuying;

	[CompilerGenerated]
	private Action<int> m_OnBuy;

	[CompilerGenerated]
	private Action<int> m_OnSold;

	public int CurPrice => 0;

	public int FirstPrice => 0;

	public bool isTodayFirstPrice => false;

	public int Assets => 0;

	public int HaveCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AddRate => 0;

	public event Action<int> OnBuy
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

	public event Action<int> OnSold
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

	public TradingHouseCommodity(int equipID)
	{
	}

	public void Refresh(STActivityTradingPostGoods severData)
	{
	}

	public void Buy(int count)
	{
	}

	public void Sold(int count)
	{
	}

	public List<int> GetTodayDistoryPrices()
	{
		return null;
	}

	public List<int> GetAllDistoryPrices()
	{
		return null;
	}
}
