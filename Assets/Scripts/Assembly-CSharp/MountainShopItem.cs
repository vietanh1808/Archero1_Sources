using UIKit;
using UnityEngine;

public class MountainShopItem : UITableViewCell
{
	[SerializeField]
	private DxxText text_Price;

	[SerializeField]
	private DxxText text_Quota;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private ButtonCtrl btn_Buy;

	[SerializeField]
	private DxxImage icon_Need;

	public GameObject Discount;

	public DxxText Text_Discount;

	private MountainShopData _data;

	protected override void Awake()
	{
	}

	public void Init(MountainShopData data)
	{
	}

	private void OnBtnBuyClick()
	{
	}

	private void Refresh()
	{
	}
}
