using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CarnivalGiftPanel : MonoBehaviour
{
	public Button bgBtn;

	public ButtonCtrl closeBtn;

	public DxxText titleTex;

	public DxxText fixTitleTex;

	public DxxText dailyTitleTex;

	private bool isOpen;

	public DxxText dailyTimeDown;

	private long showTimex;

	public RectTransform fixParend;

	public RectTransform dailyParend;

	public CarnivalGiftItem copyObj;

	private List<CarnivalGiftItem> fixItems;

	private List<CarnivalGiftItem> dailyItems;

	public RectTransform layoutGroup;

	public GridLayoutGroup fixlayout;

	public GridLayoutGroup dailylayout;

	private CarnivalShopPanel ctrl;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_RefreshList;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(CarnivalShopPanel parent)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	private void RefreshTime()
	{
	}

	private void UpdateTime()
	{
	}

	private void RefreshList(bool isOpen)
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}
}
