using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class CashGiftItemCell : UITableViewCell
{
	public PropOneEquip[] Rewards;

	public DxxText Text_Rev;

	public Slider slider;

	public DxxText Text_Info;

	public DxxText slider_count;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject Red;

	public LocalSave.CashGiftItemData data;

	public Image bgImage;

	public Image titleImage;

	public Image rewardbgImage;

	public bool isBottom;

	public Color norColor;

	public Color BigColor;

	protected new void Awake()
	{
	}

	public void init(LocalSave.CashGiftItemData data)
	{
	}

	public void onButtonGet()
	{
	}
}
