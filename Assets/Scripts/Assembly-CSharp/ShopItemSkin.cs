using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopItemSkin : MonoBehaviour
{
	public Image Bg;

	public Image imgTop;

	public Image imgBottom;

	public DxxText Text_Title;

	public ButtonCtrl Button_Get;

	public Image Image_Icon;

	public DxxText Text_Count;

	public GoldTextCtrl mGoldCtrl;

	public DxxText moneyText;

	public Action<int, ShopItemSkin> OnClickButton;

	public GameObject firstBuyLine;

	public DxxText firstBuyDesc;

	public DxxText firstBuyHint;

	public GameObject StarDiamondObj;

	public DxxText Text_StarDiamond;

	public bool isShowStarDiamond;

	protected int mIndex;

	private int[] skinCount;

	public static string[] skinPrice;

	private int[] skinId;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnButtonClick;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_getSkinPrice;

	private static DelegateBridge __Hotfix0_getSkinCount;

	private static DelegateBridge __Hotfix0_GetSkinId;

	private static DelegateBridge __Hotfix0_freshUI;

	private static DelegateBridge __Hotfix0_BuyThis;

	private static DelegateBridge __Hotfix0_isFirstDouble;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public virtual void Init(int index)
	{
	}

	public void OnLanguageChange()
	{
	}

	public virtual void OnButtonClick()
	{
	}

	public void UpdateNet()
	{
	}

	public string getSkinPrice()
	{
		return null;
	}

	public int getSkinCount()
	{
		return 0;
	}

	public int GetSkinId()
	{
		return 0;
	}

	public void freshUI()
	{
	}

	public void BuyThis()
	{
	}

	public bool isFirstDouble()
	{
		return false;
	}
}
