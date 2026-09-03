using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class TradingHousePanel : MonoBehaviour, TradingHouseUIPanel.IPanelBase
{
	public TradingHouseAssetNum[] assetNums;

	public DxxText refreshTimeText;

	public DxxText logBtnText;

	public DxxText sellBtnText;

	public DxxText buyBtnText;

	public ButtonCtrl logBtn;

	public ButtonCtrl sellBtn;

	public ButtonCtrl buyBtn;

	public TradingHouseCommondityItem copyOne;

	public RectTransform ItemParent;

	public TradingPriceDrawCtrl priceDrawCtrl;

	public ScrollRect scrollRect;

	[CompilerGenerated]
	private Action m_OnOpenLogPanel;

	[CompilerGenerated]
	private Action<TradingHouseCommodity, TradingHouseBehavior> m_OnOpenSellPanel;

	private TradingHouseCommodity mCommodity;

	private List<TradingHouseCommondityItem> commondityItems;

	private TimeLineContainer timeLine;

	private TimeLineContainer reqTimeLine;

	private const string guideKey = "TradingHouseGuide";

	public event Action OnOpenLogPanel
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

	public event Action<TradingHouseCommodity, TradingHouseBehavior> OnOpenSellPanel
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

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Refresh(bool isSuccess)
	{
	}

	private void RefreshNums()
	{
	}

	private void RefreshCommonditys()
	{
	}

	public void Close()
	{
	}

	private void Select(TradingHouseCommodity commodity)
	{
	}

	private void ClickLog()
	{
	}

	private void ClickSell()
	{
	}

	private void ClickBuy()
	{
	}

	private void freshTime()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void StartGuide()
	{
	}
}
