using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ManorWorkerSystemItem : UITableViewCell
{
	private static Material _gray;

	public GameObject StarsShow;

	public DxxText txt_Star;

	public DxxImage img_Star;

	public Image Image_Worker;

	public Image Image_BG;

	public ButtonCtrl btn_Click;

	public DxxText txt_Add;

	public HellItemWearStateCtrl wearStateCtrl;

	private HellSystemItemData wkData;

	private int Len;

	public static Material GrayMaterial => null;

	public void Init(HellSystemItemData itemData, HellSystemBuffType hType)
	{
	}

	public void SetGray(bool ifGray)
	{
	}
}
