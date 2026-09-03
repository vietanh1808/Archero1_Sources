using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class ShopSkinSingleUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ScrollRectBase mScrollRect;

	public RectTransform window;

	private ShopSkinSingleProxy.Transfer mTransfer;

	private List<ShopOneBase> mShopItemList;

	private Dictionary<string, Func<bool>> mOpenCondition;

	private Action onUIClose;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateList()
	{
	}

	private ShopOneBase GetShop(string path)
	{
		return null;
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
