using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingMapRankItemCell : UITableViewCell
{
	public GameObject BG_Focus;

	public Image Image_Left;

	public Image Image_Flower;

	public Image Image_Cup;

	public DxxText Text_Rank;

	public DxxText Text_Name;

	public Image Image_Military;

	public DxxText Text_Military;

	public DxxText Text_Distance;

	public HeadItem headItem;

	public ButtonCtrl headClick;

	public ButtonCtrl Button_Goto;

	public DxxText Text_Goto;

	private SailingMapItemData itemData;

	public void init(SailingMapItemData data)
	{
	}

	public void onButtonGoto()
	{
	}

	private void onButtonHead()
	{
	}
}
