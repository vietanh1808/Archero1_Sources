using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CarnivalShopPanel : MonoBehaviour
{
	private DxxText Text_Time;

	private bool isOpen;

	public DxxText matNum;

	public DxxText giftBtnTex;

	public ButtonCtrl giftBtn;

	public DxxText fixTitle;

	public DxxText dailyTitle;

	public DxxText dailyTimeDown;

	public CarnivalGiftPanel carnivalGiftPanel;

	public RectTransform fixParend;

	public RectTransform dailyParend;

	public CarnivalShopItem copyObj;

	private List<CarnivalShopItem> fixItems;

	private List<CarnivalShopItem> dailyItems;

	public RectTransform layoutGroup;

	public GridLayoutGroup fixlayout;

	public GridLayoutGroup dailylayout;

	private long showTimex;

	private long showTimex2;

	private string timelk;

	public ButtonCtrl tipButton;

	public GameObject popTips;

	public DxxText popTitle;

	public DxxText popContent;

	public ButtonCtrl popCloseBtn;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_RefreshMat;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_RefreshList;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(DxxText textTime)
	{
	}

	public void Open()
	{
	}

	public void RefreshMat()
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

	private void RefreshList()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}
}
