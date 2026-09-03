using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act6thShopItem : UITableViewCell
{
	public PropOneEquip propItem;

	public DxxText Text_Limit;

	public Image Image_Icon;

	public DxxText Text_Count;

	public ButtonCtrl Button_Buy;

	public GameObject Mask;

	public GameObject DiscountObj;

	public DxxText Text_Discount;

	public DxxText Text_DiscountDesc;

	private Act6thShopItemData itemData;

	public new void Awake()
	{
	}

	public void init(Act6thShopItemData data)
	{
	}

	private void onButtonBuy()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}
}
