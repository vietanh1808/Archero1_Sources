using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopItemDiamond : MonoBehaviour
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Get;

	public Image Image_Icon;

	public DxxText Text_Count;

	public DxxText Text_Money;

	public bool FristBuy;

	public DxxText Double_Text;

	public DxxText txtDoubleDesc;

	public GameObject Double_Title;

	private string ProductIDReal;

	public GameObject StarDimondObj;

	public DxxText Text_StarDiamond;

	private Shop_Shop shopdata;

	private int mIndex;

	private static DelegateBridge __Hotfix0_PurchaseFly;

	private static DelegateBridge __Hotfix0_PurchaseFlyInternal;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnClickButtonInternal;

	private static DelegateBridge __Hotfix0_OnClickButtonStar;

	private static DelegateBridge __Hotfix0_GetDoubleDiamondID;

	private static DelegateBridge __Hotfix0_GetDoubleNum;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_freshItem;

	private static DelegateBridge __Hotfix0_HideTitle;

	private static DelegateBridge __Hotfix0_ShowTitle;

	private static DelegateBridge __Hotfix0_GetDiamond;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_secondTips;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static void PurchaseFly(string id, Transform t)
	{
	}

	private static void PurchaseFlyInternal(string id, Transform t)
	{
	}

	private void Awake()
	{
	}

	private void OnClickButtonInternal(string productID)
	{
	}

	private void OnClickButtonStar()
	{
	}

	public string GetDoubleDiamondID(int mIndex)
	{
		return null;
	}

	public string GetDoubleNum(int mIndex)
	{
		return null;
	}

	public void Init(List<int> doubleList, int index)
	{
	}

	private void freshItem()
	{
	}

	public void HideTitle()
	{
	}

	public void ShowTitle()
	{
	}

	public int GetDiamond()
	{
		return 0;
	}

	public void OnLanguageChange()
	{
	}

	public void UpdateNet()
	{
	}

	private void secondTips()
	{
	}
}
