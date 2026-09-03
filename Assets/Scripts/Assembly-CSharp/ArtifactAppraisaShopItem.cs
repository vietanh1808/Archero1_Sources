using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactAppraisaShopItem : UITableViewCell
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

	private ArtifactAppraisaShopItemData itemData;

	public new void Awake()
	{
	}

	public void init(ArtifactAppraisaShopItemData data)
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
