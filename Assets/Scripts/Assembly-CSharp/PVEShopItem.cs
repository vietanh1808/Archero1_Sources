using UIKit;
using UnityEngine;

public class PVEShopItem : UITableViewCell
{
	public DxxText Text_Title;

	public DxxText Text_Count;

	public DxxText Text_Need;

	public GameObject Image_Icon2;

	public GameObject Image_Icon12;

	public GameObject Image_Icon32;

	public PropOneEquip prop;

	public ButtonCtrl Button_Buy;

	public GameObject Mask;

	private PVEShopDataNormal itemData;

	public GameObject crit;

	public DxxText Text_X;

	public DxxText Text_Discount;

	public void init(PVEShopDataNormal data)
	{
	}

	public void onButtonClick()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}
}
