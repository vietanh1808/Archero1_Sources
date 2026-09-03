using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PushPillarShopItem : UITableViewCell
{
	public Image bg;

	public PropOneEquip propItem;

	public DxxText limitText;

	public ButtonCtrl buyBtn;

	public Image iconImg;

	public DxxText countText;

	public GameObject mask;

	public GameObject checkMark;

	public GameObject DiscountObj;

	public DxxText Text_Discount;

	public DxxText Text_DiscountDesc;

	private PushPillarShopData itemData;

	public new void Awake()
	{
	}

	public void init(PushPillarShopData data)
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
