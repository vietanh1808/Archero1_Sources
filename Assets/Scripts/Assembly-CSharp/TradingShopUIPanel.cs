using PureMVC.Interfaces;
using UnityEngine;

public class TradingShopUIPanel : MonoBehaviour, TradingHouseUIPanel.IPanelBase
{
	public TradingShopLineItem shopLine;

	public RectTransform lineParent;

	private LocalUnityObjctPool _pool;

	private const int LINE_PROP_COUNT = 3;

	private TradingShopData SData => null;

	public void Init()
	{
	}

	public void Open()
	{
	}

	private void RefreshList()
	{
	}

	public void Close()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}
}
