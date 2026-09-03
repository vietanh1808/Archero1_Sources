using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BlackItemOnectrl : MonoBehaviour
{
	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Other;

	public RectTransform Rect_Button_Other;

	public RectTransform Rect_Button_Discount;

	public RectTransform redLine;

	public RectTransform Rect_mGoldCtrl;

	public RectTransform Rect_oldGoldCtrl;

	public RectTransform Rect_newGoldCtrl;

	public ButtonCtrl Button_Discount;

	public GameObject equipparent;

	public Image Image_Buy;

	public GoldTextCtrl mGoldCtrl;

	public GoldTextCtrl oldGoldCtrl;

	public GoldTextCtrl newGoldCtrl;

	public GameObject Discount;

	public DxxText Text_Discount;

	public DxxText Text_Discountnum;

	public DxxText Text_Name;

	public DxxText Text_Sold;

	public RedNodeCtrl redNodCtrl;

	public GameObject buyparent;

	public GameObject notbuyparent;

	public Action<BlackItemOnectrl> OnClickButton;

	public Shop_MysticShop mData;

	private PropOneEquip mItem;

	private Equip_equip equipdata;

	private LocalSave.EquipOne mEquipOne;

	public int mIndex;

	private bool bBuy;

	private void Awake()
	{
	}

	public void Init(int index, Shop_MysticShop data)
	{
	}

	private void SetBuy(bool buy)
	{
	}

	public void SetCurrencyShow(bool value)
	{
	}

	public void UpdateCurrency()
	{
	}

	public void Buy()
	{
	}

	public bool HaveDiscount(Shop_MysticShop data)
	{
		return false;
	}

	private void InitDiscount(Shop_MysticShop data)
	{
	}
}
