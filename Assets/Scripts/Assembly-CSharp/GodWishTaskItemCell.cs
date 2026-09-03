using UIKit;
using UnityEngine;

public class GodWishTaskItemCell : UITableViewCell
{
	public PropOneEquip[] propItems;

	public DxxText Text_Title;

	public DxxText Text_Progress;

	public ButtonCtrl Button_Go;

	public DxxText Text_Go;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject Mask;

	public GameObject RedPoint;

	private GodWishTaskItemData itemData;

	public new void Awake()
	{
	}

	public void init(GodWishTaskItemData data)
	{
	}

	private void onButtonGet()
	{
	}
}
