using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTownSkinUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText attrName;

	[SerializeField]
	private DxxText skinName;

	[SerializeField]
	private DxxText skinQuality;

	[SerializeField]
	private Transform itemParent;

	[SerializeField]
	private Transform attrParent;

	[SerializeField]
	private Image skinImg;

	[SerializeField]
	private ButtonCtrl info;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private ButtonCtrl clickLeft;

	[SerializeField]
	private ButtonCtrl clickRight;

	[SerializeField]
	private GameObject leftArrow;

	[SerializeField]
	private GameObject rightArrow;

	[SerializeField]
	private CampTownSkinItem skinItem;

	[SerializeField]
	private CampTownSkinAttributeItem attributeItem;

	[SerializeField]
	private GameObject buyStatus;

	[SerializeField]
	private GameObject purchaseStatus;

	[SerializeField]
	private GameObject activityGetStatus;

	[SerializeField]
	private GameObject unlockStatus;

	[SerializeField]
	private DxxText buyName;

	[SerializeField]
	private DxxText purchaseName;

	[SerializeField]
	private DxxText activityGetName;

	[SerializeField]
	private DxxText unlockName;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private HorizontalLayoutGroup horizontalLayoutGroup;

	[SerializeField]
	private DxxText timeDesc;

	[SerializeField]
	private FitContentText noneAttrDesc;

	[SerializeField]
	private RectTransform skinIconRect;

	private CampTownSkinItemData itemData;

	private LocalUnityObjctPool pool;

	private int usingSkinIndex;

	private int curSelectID;

	private static DelegateBridge __Hotfix0_get_CampTownSkinManager;

	private static DelegateBridge __Hotfix0_get_CampTownSkinData;

	private static DelegateBridge __Hotfix0_get_ItemWidth;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshScroll;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshSkinItem;

	private static DelegateBridge __Hotfix0_RefreshAttrItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_ClickLeft;

	private static DelegateBridge __Hotfix0_ClickRight;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_RequestUse;

	private static DelegateBridge __Hotfix0_RequestBuy;

	private static DelegateBridge __Hotfix0_RequestPurchase;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge __Hotfix0_GetHorizontalMaxWidth;

	private static DelegateBridge __Hotfix0_GetHorizontalOriginWidth;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTownSkinManager CampTownSkinManager => null;

	private CampTownSkinData CampTownSkinData => null;

	private float ItemWidth => 0f;

	private void InitPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void Refresh()
	{
	}

	private void RefreshScroll()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshSkinItem()
	{
	}

	private void RefreshAttrItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickLeft()
	{
	}

	private void ClickRight()
	{
	}

	private void ClickInfo()
	{
	}

	private void Click()
	{
	}

	private void RequestUse()
	{
	}

	private void RequestBuy()
	{
	}

	private void RequestPurchase()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void Esc()
	{
	}

	private float GetHorizontalMaxWidth()
	{
		return 0f;
	}

	private float GetHorizontalOriginWidth()
	{
		return 0f;
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
