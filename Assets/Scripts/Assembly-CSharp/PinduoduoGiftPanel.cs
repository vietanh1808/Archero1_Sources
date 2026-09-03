using System;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PinduoduoGiftPanel : MonoBehaviour, PinduoduoGiftUIPanel.IPanelBase
{
	public DxxText matNumText;

	public Image matIconImg;

	public ButtonCtrl BuyMatBtn;

	public PinduoduoFinalGiftItem FinalGiftItem;

	public PinduoduoBaseGiftItem BaseGiftItem;

	public PinduoduoPrivilegePart PrivilegePart;

	public Action<int, bool> onClickBuyCallBack;

	private PinduoduoGiftGroupData mData;

	public void Init()
	{
	}

	public void Open(object data)
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

	private void clickBuyMat()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshMat()
	{
	}

	private void OnReqFinalGiftCallBack(bool obj)
	{
	}

	private void OnReqTaskCallBack(bool obj)
	{
	}

	private void OnReqQuickBuyCallBack(bool obj)
	{
	}
}
