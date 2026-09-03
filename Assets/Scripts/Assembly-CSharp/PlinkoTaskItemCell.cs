using UIKit;
using UnityEngine;

public class PlinkoTaskItemCell : UITableViewCell
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

	private PlinkoTaskItemData itemData;

	public new void Awake()
	{
	}

	public void init(PlinkoTaskItemData data)
	{
	}

	private void onButtonGet()
	{
	}
}
